CREATE OR ALTER PROCEDURE [dbo].[UpdateAppointmentStatus] 
AS 
BEGIN
	DECLARE @Today AS datetime2 = getdate()
	-- CASE 1: missed appointments
	UPDATE app 
		SET app.appointmentstatus = -1,
			app.dateedited = @Today,
			app.dayslate = (SELECT datediff(day, app.appointmentdate, @Today)) 
	FROM [dbo].[Appointments] app 
	WHERE app.appointmentdate < @Today 
	AND app.interactiondate IS NULL AND app.appointmentstatus = 0;
	-- update days late on missed appointments
	UPDATE app
		SET app.DaysLate = (SELECT datediff(day, app.appointmentdate, @Today))
	FROM [dbo].[Appointments] app
	WHERE app.AppointmentStatus = -1
	
	-- CASE 2: attended appointments
	UPDATE app 
		SET app.appointmentstatus = 1,
			app.dateedited = @Today 
	FROM [dbo].[Appointments] app 
	WHERE app.interactiondate IS NOT NULL 
	AND app.appointmentstatus = 0 
	AND app.interactiondate > app.appointmentdate;
	
	-- CASE 3: pending appointments
	UPDATE app 
		SET app.appointmentstatus = 0, 
		app.dateedited = @Today 
	FROM [dbo].[Appointments] app 
	WHERE app.interactiondate IS NULL AND app.appointmentdate > @Today;

END 
-- run procedure
GO
EXECUTE [dbo].[UpdateAppointmentStatus];
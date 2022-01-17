USE [CTSMigrationDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateAppointmentStatus]    Script Date: 13/01/2022 12:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER   PROCEDURE [dbo].[UpdateAppointmentStatus] 
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
	WHERE app.AppointmentStatus = -1;
	
	-- CASE 2: attended appointments that are still pending
	UPDATE app 
		SET app.appointmentstatus = 1,
			app.dateedited = @Today 
	FROM [dbo].[Appointments] app 
	WHERE app.interactiondate IS NOT NULL 
	AND app.appointmentstatus = 0
	AND app.InteractionDate < @Today;

	-- CASE 3: attended appointment that are still missed
	UPDATE app 
		SET app.appointmentstatus = 1,
			app.dateedited = @Today 
	FROM [dbo].[Appointments] app 
	WHERE app.interactiondate IS NOT NULL 
	AND app.appointmentstatus = -1
	AND app.InteractionDate < @Today;
	

END 
-- run procedure

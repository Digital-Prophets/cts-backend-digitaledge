USE [CTSMigrationDB]
GO

/****** Object:  Trigger [dbo].[AppointmentStatusTrigger]    Script Date: 17/01/2022 15:06:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE OR ALTER     TRIGGER [dbo].[AppointmentStatusTrigger] ON [dbo].[Appointments]
AFTER UPDATE 
AS
BEGIN
	SET NOCOUNT ON;
	EXEC UpdateAppointmentStatus;
END
GO

ALTER TABLE [dbo].[Appointments] ENABLE TRIGGER [AppointmentStatusTrigger]
GO



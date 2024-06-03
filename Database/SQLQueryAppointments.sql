USE [Hospital]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetAllAppointmentsDateByDoctorAndDate]    Script Date: 03/06/2024 04:05:35 م ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





Create PROCEDURE [dbo].[SP_GetAllAppointmentsDateByDoctorAndDate]
	@DoctorID INT,
	@Year smallint,
	@Month tinyint,
	@Day tinyint
AS
BEGIN
select AppointmentDateTime from Appointments  where AppointmentStatus=1 and DoctorID=@DoctorID and @Year= Year(AppointmentDateTime) and @Month= Month(AppointmentDateTime) and @Day= Day(AppointmentDateTime)
END
GO


USE [Hospital]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetAllAppointmentsHourByDoctorAndDate]    Script Date: 03/06/2024 04:06:09 م ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






Create PROCEDURE [dbo].[SP_GetAllAppointmentsHourByDoctorAndDate]
	@DoctorID INT,
	@Year smallint,
	@Month tinyint,
	@Day tinyint
AS
BEGIN
select DATEPART(HOUR,AppointmentDateTime) from  Appointments where AppointmentStatus=1 and DoctorID=@DoctorID and @Year= Year(AppointmentDateTime) and @Month= Month(AppointmentDateTime) and @Day= Day(AppointmentDateTime)
END
GO



USE [Hospital]
GO

/****** Object:  StoredProcedure [dbo].[SP_IsAppointmentExistByDoctorIDAndDate]    Script Date: 03/06/2024 04:06:39 م ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO









--==========================================================================================================================

Create PROCEDURE [dbo].[SP_IsAppointmentExistByDoctorIDAndDate]
	@DoctorID INT,
	@Year smallint,
	@Month tinyint,
	@Day tinyint,
	@Hour tinyint
AS
BEGIN

      IF EXISTS (SELECT FOUND = 1 FROM Appointments WHERE AppointmentStatus=1 and Appointments.DoctorID = @DoctorID and Year(AppointmentDateTime)=@Year and Month(AppointmentDateTime) =@Month and Day(AppointmentDateTime)=@Day and  DATEPART(HOUR,AppointmentDateTime)=@Hour)
            RETURN 1;
      ELSE
            RETURN 0;

END
GO


USE [Hospital]
GO

/****** Object:  StoredProcedure [dbo].[SP_IsAppointmentExistByPatientIDAndDate]    Script Date: 03/06/2024 04:07:11 م ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO









--==========================================================================================================================

Create PROCEDURE [dbo].[SP_IsAppointmentExistByPatientIDAndDate]
	@PatientID INT,
	@Year smallint,
	@Month tinyint,
	@Day tinyint,
	@Hour tinyint
AS
BEGIN

      IF EXISTS (SELECT FOUND = 1 FROM Appointments WHERE AppointmentStatus=1 and  Appointments.PatientID = @PatientID and Year(AppointmentDateTime)=@Year and Month(AppointmentDateTime) =@Month and Day(AppointmentDateTime)=@Day and  DATEPART(HOUR,AppointmentDateTime)=@Hour)
            RETURN 1;
      ELSE
            RETURN 0;

END
GO




USE [Hospital]
GO

/****** Object:  View [dbo].[View_Appointments]    Script Date: 11/06/2024 10:11:48 ? ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Appointments]
AS
SELECT        dbo.Appointments.AppointmentID, dbo.Patients.PatientID, People_1.FirstName + ' ' + People_1.LastName AS PatientFullName, People_1.NationalNo, dbo.Contacts.PhoneNumber AS PatientPhoneNumber, 
                         CASE WHEN People_1.Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender, dbo.Countries.CountryName, dbo.Appointments.AppointmentDateTime, Doctors_1.DoctorID,
                             (SELECT        dbo.People.FirstName + dbo.People.LastName AS Expr1
                               FROM            dbo.People INNER JOIN
                                                         dbo.Employees ON dbo.People.PersonID = dbo.Employees.PersonID INNER JOIN
                                                         dbo.Doctors ON dbo.Doctors.EmployeeID = dbo.Employees.EmployeeID
                               WHERE        (dbo.Doctors.DoctorID = dbo.Doctors.DoctorID)) AS DoctorName, dbo.Appointments.TotalPrice, 
                         CASE WHEN dbo.Appointments.AppointmentStatus = 1 THEN 'New' WHEN dbo.Appointments.AppointmentStatus = 2 THEN 'Cencelled' WHEN dbo.Appointments.AppointmentStatus = 3 THEN 'Completed' END AS Status
FROM            dbo.Doctors AS Doctors_1 INNER JOIN
                         dbo.Appointments ON Doctors_1.DoctorID = dbo.Appointments.DoctorID INNER JOIN
                         dbo.Patients ON dbo.Appointments.PatientID = dbo.Patients.PatientID INNER JOIN
                         dbo.Contacts INNER JOIN
                         dbo.People AS People_1 ON dbo.Contacts.ContactID = People_1.ContactID ON dbo.Patients.PersonID = People_1.PersonID INNER JOIN
                         dbo.Countries ON People_1.CountryID = dbo.Countries.CountryID
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Doctors_1"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Appointments"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Patients"
            Begin Extent = 
               Top = 6
               Left = 494
               Bottom = 102
               Right = 664
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Contacts"
            Begin Extent = 
               Top = 6
               Left = 702
               Bottom = 119
               Right = 872
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "People_1"
            Begin Extent = 
               Top = 102
               Left = 494
               Bottom = 232
               Right = 664
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Countries"
            Begin Extent = 
               Top = 120
               Left = 702
               Bottom = 216
               Right = 872
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Appointments'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Appointments'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Appointments'
GO


USE [Hospital]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetAllAppointments]    Script Date: 11/06/2024 10:14:24 ? ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- Get All Appointments
ALTER PROCEDURE [dbo].[SP_GetAllAppointments]
AS
BEGIN
    select * from View_Appointments  where Status ='Completed';
END;
GO

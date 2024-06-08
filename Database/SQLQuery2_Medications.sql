
USE [Hospital]
GO

/****** Object:  Table [dbo].[Medications]    Script Date: 6/7/2024 1:13:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Medications](
	[MedicationID] [int] IDENTITY(1,1) NOT NULL,
	[MedicationName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Medications] PRIMARY KEY CLUSTERED 
(
	[MedicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE PROCEDURE SP_GetAllMedications
AS
BEGIN
	SELECT * FROM Medications;
END

GO

CREATE PROCEDURE SP_AddNewMedication
@MedicationName NVARCHAR(100),
@NewMedicationID int OUTPUT
AS
BEGIN
	INSERT INTO Medications(MedicationName)VALUES(@MedicationName);
	set @NewMedicationID = SCOPE_IDENTITY();
END

GO

CREATE PROCEDURE SP_UpdateMedication
@MedicationID int,
@MedicationName NVARCHAR(100)
AS
BEGIN
	UPDATE Medications 
	SET
	MedicationName = @MedicationName
	WHERE
	MedicationID = @MedicationID;
END

GO

CREATE PROCEDURE SP_DeleteMedication
@MedicationID int
AS
BEGIN
DELETE FROM Medications WHERE MedicationID = @MedicationID;
END

GO

CREATE PROCEDURE SP_FindMedication
@MedicationID int
AS
BEGIN
SELECT TOP 1 * FROM Medications WHERE MedicationID = @MedicationID;
END

GO
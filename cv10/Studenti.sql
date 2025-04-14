CREATE TABLE [dbo].[Studenti] (
    [ID_Student] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Jmeno] VARCHAR(50) NOT NULL,
    [Prijmeni] VARCHAR(50) NOT NULL,
    [DatumNarozeni] DATE NOT NULL
)
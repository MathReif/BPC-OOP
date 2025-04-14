CREATE TABLE [dbo].[Hodnoceni] (
    [ID_Student] INT NOT NULL,
    [Zkratka_Predmetu] VARCHAR(10) NOT NULL,
    [DatumHodnoceni] DATE NOT NULL,
    [Hodnoceni] INT NOT NULL CHECK ([Hodnoceni] BETWEEN 1 AND 5),
    PRIMARY KEY ([ID_Student], [Zkratka_Predmetu], [DatumHodnoceni]),
    FOREIGN KEY ([ID_Student]) REFERENCES [dbo].[Studenti]([ID_Student]),
    FOREIGN KEY ([Zkratka_Predmetu]) REFERENCES [dbo].[Predmety]([Zkratka])
);
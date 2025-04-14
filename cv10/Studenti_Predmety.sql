CREATE TABLE [dbo].[Studenti_Predmety] (
    [ID_Student] INT NOT NULL,
    [Zkratka_Predmetu] VARCHAR(10) NOT NULL,
    PRIMARY KEY ([ID_Student], [Zkratka_Predmetu]),
    FOREIGN KEY ([ID_Student]) REFERENCES [dbo].[Studenti]([ID_Student]),
    FOREIGN KEY ([Zkratka_Predmetu]) REFERENCES [dbo].[Predmety]([Zkratka])
);
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This script contains all data population statements for the Vyuka database
 It will run after the database schema is created
--------------------------------------------------------------------------------------
*/

PRINT 'Starting data population for Vyuka database...'

-- Clear existing data (optional - uncomment if you want to reset data)
/*
DELETE FROM [dbo].[Hodnoceni];
DELETE FROM [dbo].[Studenti_Predmety];
DELETE FROM [dbo].[Studenti];
DELETE FROM [dbo].[Predmety];
PRINT 'All existing data cleared';
*/

-- 1. Insert Subjects (Predmety)
IF NOT EXISTS (SELECT 1 FROM [dbo].[Predmety])
BEGIN
    INSERT INTO [dbo].[Predmety] ([Zkratka], [Nazev]) VALUES
    ('MAT', 'Matematika'),
    ('CJL', 'Český jazyk a literatura'),
    ('PRG', 'Programování'),
    ('ANJ', 'Anglický jazyk'),
    ('DEJ', 'Dějepis'),
    ('FYZ', 'Fyzika');
    
    PRINT 'Inserted 6 subjects into Predmety table';
END
ELSE
BEGIN
    PRINT 'Predmety table already contains data - skipping insertion';
END

-- 2. Insert Students (Studenti)
IF NOT EXISTS (SELECT 1 FROM [dbo].[Studenti])
BEGIN
    INSERT INTO [dbo].[Studenti] ([Jmeno], [Prijmeni], [DatumNarozeni]) VALUES
    ('Jan', 'Novák', '2000-05-15'),
    ('Petr', 'Svoboda', '2001-03-22'),
    ('Anna', 'Dvořáková', '1999-11-30'),
    ('Eva', 'Nováková', '2000-07-10'),
    ('Karel', 'Malý', '2001-01-05'),
    ('Lucie', 'Svobodová', '2000-09-18'),
    ('Tomáš', 'Černý', '1999-12-25'),
    ('Jana', 'Malá', '2001-04-03');
    
    PRINT 'Inserted 8 students into Studenti table';
END
ELSE
BEGIN
    PRINT 'Studenti table already contains data - skipping insertion';
END

-- 3. Insert Student-Subject relationships (Studenti_Predmety)
IF NOT EXISTS (SELECT 1 FROM [dbo].[Studenti_Predmety])
BEGIN
    INSERT INTO [dbo].[Studenti_Predmety] ([ID_Student], [Zkratka_Predmetu]) VALUES
    (1, 'MAT'), (1, 'CJL'), (1, 'PRG'),
    (2, 'MAT'), (2, 'ANJ'),
    (3, 'CJL'), (3, 'DEJ'), (3, 'FYZ'),
    (4, 'MAT'), (4, 'PRG'), (4, 'FYZ'),
    (5, 'ANJ'), (5, 'DEJ'),
    (6, 'MAT'), (6, 'CJL'), (6, 'PRG'), (6, 'ANJ'),
    (7, 'DEJ'), (7, 'FYZ'),
    (8, 'MAT'), (8, 'PRG');
    
    PRINT 'Inserted student-subject relationships into Studenti_Predmety table';
END
ELSE
BEGIN
    PRINT 'Studenti_Predmety table already contains data - skipping insertion';
END

-- 4. Insert Grades (Hodnoceni)
IF NOT EXISTS (SELECT 1 FROM [dbo].[Hodnoceni])
BEGIN
    INSERT INTO [dbo].[Hodnoceni] ([ID_Student], [Zkratka_Predmetu], [DatumHodnoceni], [Hodnoceni]) VALUES
    (1, 'MAT', '2023-01-15', 2),
    (1, 'CJL', '2023-01-20', 1),
    (1, 'PRG', '2023-01-25', 1),
    (2, 'MAT', '2023-01-16', 3),
    (2, 'ANJ', '2023-01-22', 2),
    (3, 'CJL', '2023-01-18', 2),
    (3, 'DEJ', '2023-01-19', 1),
    (3, 'FYZ', '2023-01-21', 3),
    (4, 'MAT', '2023-01-17', 1),
    (4, 'PRG', '2023-01-23', 2),
    (4, 'FYZ', '2023-01-24', 2),
    (5, 'ANJ', '2023-01-20', 4),
    (5, 'DEJ', '2023-01-25', 3),
    (6, 'MAT', '2023-01-15', 2),
    (6, 'CJL', '2023-01-18', 1),
    (6, 'PRG', '2023-01-22', 1),
    (6, 'ANJ', '2023-01-24', 2),
    (7, 'DEJ', '2023-01-19', 5),
    (7, 'FYZ', '2023-01-23', 4),
    (8, 'MAT', '2023-01-16', 3),
    (8, 'PRG', '2023-01-21', 2);
    
    PRINT 'Inserted 21 grades into Hodnoceni table';
END
ELSE
BEGIN
    PRINT 'Hodnoceni table already contains data - skipping insertion';
END

PRINT 'Data population completed successfully';
GO
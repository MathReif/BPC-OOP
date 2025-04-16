/*
DELETE FROM [dbo].[Hodnoceni];
DELETE FROM [dbo].[Studenti_Predmety];
DELETE FROM [dbo].[Studenti];
DELETE FROM [dbo].[Predmety];
PRINT 'All existing data cleared';
*/
SELECT 
    Student.Meno,
    Student.Priezvisko,
    Predmet.Nazev AS Predmet
FROM 
    Student
LEFT JOIN 
    Student_Predmet ON Student.ID = Student_Predmet.ID
LEFT JOIN 
    Predmet ON Student_Predmet.Zkratka = Predmet.Zkratka

SELECT 
    Priezvisko,
    COUNT(*) AS Pocet
FROM 
    Student
GROUP BY 
    Priezvisko
ORDER BY 
    Pocet DESC;

SELECT 
    Predmet.Zkratka,
    Predmet.Nazev,
    COUNT(  Student_Predmet.ID) AS pocet_studentu
FROM 
    Predmet
JOIN 
    Student_Predmet ON Predmet.Zkratka = Student_Predmet.Zkratka
GROUP BY 
    Predmet.Nazev,
    Predmet.Zkratka
HAVING 
    COUNT(Student_Predmet.ID) < 3;

SELECT 
    Predmet.Nazev,
    MAX(Hodnocenie.Znamka) AS nejlepsi_hodnoceni,
    MIN(Hodnocenie.Znamka) AS nejhorsi_hodnoceni,
    AVG(Hodnocenie.Znamka) AS prumerne_hodnoceni,
    COUNT(Hodnocenie.ID) AS pocet_hodnocenych_studentu
FROM 
    Predmet
JOIN 
    Hodnocenie ON Predmet.Zkratka = Hodnocenie.Zkratka
GROUP BY 
    Predmet.Nazev;
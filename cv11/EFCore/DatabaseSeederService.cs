using System.Collections.Generic;

namespace cv11.EFCore
{
    public class DatabaseSeederService
    {
        private readonly VyukaContext _context;

        public DatabaseSeederService(VyukaContext context)
        {
            _context = context;
        }

        public void SeedDatabase()
        {
            if (!_context.Students.Any())
            {
                _context.Students.Add(new Student { Id = 1, Jmeno = "Jan", Prijmeni = "Novak", DatumNarozeni = new DateTime(1990, 1, 1) });
                _context.Students.Add(new Student { Id = 2, Jmeno = "Petr", Prijmeni = "Kral", DatumNarozeni = new DateTime(1991, 2, 2) });
                _context.Students.Add(new Student { Id = 3, Jmeno = "Pavla", Prijmeni = "Nová", DatumNarozeni = new DateTime(1994, 4, 2) });
                _context.Students.Add(new Student { Id = 4, Jmeno = "Karel", Prijmeni = "Novotný", DatumNarozeni = new DateTime(1994, 5, 6) });
                _context.SaveChanges();  
            }

            if (!_context.Predmets.Any())
            {
                _context.Predmets.Add(new Predmet { Zkratka = "BOOP", Nazev = "Objektově orientované programování" });
                _context.Predmets.Add(new Predmet { Zkratka = "BPC1T", Nazev = "Počítače a programování 1" });
                _context.Predmets.Add(new Predmet { Zkratka = "BANA", Nazev = "Analogová technika" });
                _context.SaveChanges();  
            }

            if (!_context.Hodnocenis.Any())
            {
                _context.Hodnocenis.Add(new Hodnoceni { IdStudent = 1, ZkratkaPredmet = "BOOP", Datumt = DateTime.Now, Znamka = 1 });
                _context.Hodnocenis.Add(new Hodnoceni { IdStudent = 2, ZkratkaPredmet = "BANA", Datumt = DateTime.Now, Znamka = 2 });
                _context.Hodnocenis.Add(new Hodnoceni { IdStudent = 3, ZkratkaPredmet = "BPC1T", Datumt = DateTime.Now, Znamka = 3 });
                _context.Hodnocenis.Add(new Hodnoceni { IdStudent = 4, ZkratkaPredmet = "BANA", Datumt = DateTime.Now, Znamka = 2 });
                _context.Hodnocenis.Add(new Hodnoceni { IdStudent = 1, ZkratkaPredmet = "BANA", Datumt = DateTime.Now, Znamka = 1 });
                _context.SaveChanges();
            }

            if (!_context.StudentPredmets.Any())
            {
                _context.StudentPredmets.Add(new StudentPredmet { IdStudent = 1, ZkratkaPredmet = "BOOP" });
                _context.StudentPredmets.Add(new StudentPredmet { IdStudent = 2, ZkratkaPredmet = "BANA" });
                _context.StudentPredmets.Add(new StudentPredmet { IdStudent = 3, ZkratkaPredmet = "BPC1T" });
                _context.StudentPredmets.Add(new StudentPredmet { IdStudent = 4, ZkratkaPredmet = "BANA" });
                _context.StudentPredmets.Add(new StudentPredmet { IdStudent = 1, ZkratkaPredmet = "BANA" });
                _context.SaveChanges();
            }
        }

        public void DisplaySubjectsWithStudentCount()
        {
            var result = _context.StudentPredmets
                                 .GroupBy(sp => sp.ZkratkaPredmet)
                                 .Select(group => new
                                 {
                                     Predmet = group.Key,
                                     StudentCount = group.Count()
                                 })
                                 .OrderByDescending(x => x.StudentCount)
                                 .ToList();

            Console.WriteLine("Predmety: ");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Predmet}: {item.StudentCount} students");
            }
        }

        public IEnumerable<Student> StudentiPredmetu(string predmetId)
        {
            var students = _context.StudentPredmets
                                   .Where(sp => sp.ZkratkaPredmet == predmetId)
                                   .Select(sp => sp.Student)
                                   .ToList();
            return students;
        }

        public IEnumerable<Predmet> PredmetyStudenta(int studentId)
        {
            var subjects = _context.StudentPredmets
                                   .Where(sp => sp.IdStudent == studentId)
                                   .Select(sp => sp.Predmet)
                                   .ToList();
            return subjects;
        }

        public void DisplaySubjectsWithAverageGrade()
        {
            var result = _context.Hodnocenis
                                 .GroupBy(h => h.ZkratkaPredmet)
                                 .Select(group => new
                                 {
                                     Predmet = group.Key,
                                     AverageGrade = group.Average(h => h.Znamka)
                                 })
                                 .ToList();

            Console.WriteLine("Predmety s priemernou znamkou: ");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Predmet}: {item.AverageGrade:F2} priemerna znamka");
            }
        }
    }
}

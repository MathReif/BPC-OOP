using Microsoft.EntityFrameworkCore;
using cv11.EFCore;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new VyukaContext())
        {
            context.Database.Migrate();

            var seeder = new DatabaseSeederService(context);

            seeder.SeedDatabase();

            seeder.DisplaySubjectsWithStudentCount();

            seeder.DisplaySubjectsWithAverageGrade();

            var students = seeder.StudentiPredmetu("BANA");
            Console.WriteLine("Studenti BANA:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Jmeno} {student.Prijmeni}");
            }

            var subjectsForStudent1 = seeder.PredmetyStudenta(1);
            Console.WriteLine("Predmet studenta s ID 1:");
            foreach (var subject in subjectsForStudent1)
            {
                Console.WriteLine($"{subject.Nazev}");
            }
        }
    }
}

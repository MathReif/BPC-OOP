using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cv11.EFCore
{
    public class VyukaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Predmet> Predmets { get; set; }
        public DbSet<Hodnoceni> Hodnocenis { get; set; }
        public DbSet<StudentPredmet> StudentPredmets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Vyuka.mdf;Integrated Security=True;Connect Timeout=30");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hodnoceni>()
                .HasKey(h => new { h.IdStudent, h.ZkratkaPredmet });

            modelBuilder.Entity<Hodnoceni>()
                .HasOne(h => h.Student)
                .WithMany(s => s.Hodnoceni)
                .HasForeignKey(h => h.IdStudent);

            modelBuilder.Entity<Hodnoceni>()
                .HasOne(h => h.Predmet)
                .WithMany(p => p.Hodnoceni)
                .HasForeignKey(h => h.ZkratkaPredmet);

            modelBuilder.Entity<StudentPredmet>()
                .HasKey(sp => new { sp.IdStudent, sp.ZkratkaPredmet });

            modelBuilder.Entity<StudentPredmet>()
                .HasOne(sp => sp.Student)
                .WithMany(s => s.StudentPredmet)
                .HasForeignKey(sp => sp.IdStudent);

            modelBuilder.Entity<StudentPredmet>()
                .HasOne(sp => sp.Predmet)
                .WithMany(p => p.StudentPredmet)
                .HasForeignKey(sp => sp.ZkratkaPredmet);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class QuizSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=QuizSystemDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Quizes>()
                .HasOne(s => s.Student)
                .WithMany(s => s.Student_Quizes)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Student_Quizes>()
                .HasOne(s => s.Quiz)
                .WithMany(s => s.Student_Quizes)
                .HasForeignKey(s => s.QuizId);
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Student_Quizes> Students_Quizes { get; set; }
        public DbSet<StudentResult> StudentResults { get; set; }
    }
}

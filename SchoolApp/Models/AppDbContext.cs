using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id=1,
                FirstName = "Jimi",
                LastName = "Hendrix"
            });
            
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id=2,
                FirstName = "Bill",
                LastName = "Gates"
            });

            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id=3,
                FirstName = "Marie",
                LastName = "Curie"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 1,
                CourseName = "Math",
                TeacherId= 3
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 2,
                CourseName = "Chemistry",
                TeacherId = 3
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 3,
                CourseName = "Social Science",
                TeacherId = 2
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 4,
                CourseName = "Programming",
                TeacherId = 2
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 5,
                CourseName = "Music",
                TeacherId = 1
            });

            modelBuilder.Entity<Assignment>().HasData(new Assignment
            {
                AssignmentId = 1,
                Title = "Compose a rock song",
                Description = "Write a short song in a rock theme",
                CourseId = 5
            });

            modelBuilder.Entity<Assignment>().HasData(new Assignment
            {
                AssignmentId = 2,
                Title = "Practise piano",
                Description = "Spend at least 2h practising piano",
                CourseId = 5
            });

            modelBuilder.Entity<Assignment>().HasData(new Assignment
            {
                AssignmentId = 3,
                Title = "Multiplication",
                Description = "Do five pages in the math book related to multiplication",
                CourseId = 1
            });

            modelBuilder.Entity<Assignment>().HasData(new Assignment
            {
                AssignmentId = 4,
                Title = "Calculator",
                Description = "Write a code that calculates the basic operations",
                CourseId = 4
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Kalle",
                LastName = "Bäck"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Krona"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 3,
                FirstName = "Stig",
                LastName = "Ros"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 4,
                FirstName = "Anna",
                LastName = "Krook"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 5,
                FirstName = "Kalle",
                LastName = "Martinsson"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 6,
                FirstName = "Markus",
                LastName = "Stenson"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 7,
                FirstName = "Svea",
                LastName = "Nilsson"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 8,
                FirstName = "Maria",
                LastName = "Torp"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 9,
                FirstName = "Frida",
                LastName = "Truls"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 10,
                FirstName = "Dennis",
                LastName = "Fräck"
            });
        }
    }

    
}

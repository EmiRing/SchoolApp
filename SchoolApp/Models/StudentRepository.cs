using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _appDbContext;

        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Student> AllStudents => _appDbContext.Students;
        
        public Student GetStudentById(int Id)
        {
            return _appDbContext.Students.Include(s => s.Courses).FirstOrDefault(s => s.Id == Id);
        }

        public void AddStudent(Student student)
        {
            var newStudent = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Courses = student.Courses
            };

            _appDbContext.Students.Add(newStudent);
            _appDbContext.SaveChanges();
        }

        public void AddCourseToStudent(int studentId, IList<Course> courses)
        {
            var student = _appDbContext.Students.Include(c => c.Courses).FirstOrDefault(s => s.Id == studentId);

            foreach (var course in courses)
            {
                student.Courses.Add(course);
            }
            _appDbContext.SaveChanges();
        }
        
    }
}

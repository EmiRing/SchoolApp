using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _appDbContext;
        public CourseRepository(AppDbContext AppDbContext)
        {
            _appDbContext = AppDbContext;
        }

        public IEnumerable<Course> AllCourses => _appDbContext.Courses;

        public Course GetCourseById(int CourseId)
        {
            return _appDbContext.Courses.Include(c => c.Students).FirstOrDefault(c => c.CourseId == CourseId);
        }

        public void AddCourse(Course course)
        {
            var courseItem = new Course()
            {
                CourseName = course.CourseName,
                TeacherId = course.TeacherId
            };

            _appDbContext.Courses.Add(courseItem);
            _appDbContext.SaveChanges();
        }

        public void AddStudentsToCourse(int CourseId, IList<Student> students)
        {
            var course = _appDbContext.Courses.Include(s => s.Students).FirstOrDefault(c => c.CourseId == CourseId);

            foreach (var student in students)
            {
                course.Students.Add(student);
            }
            _appDbContext.SaveChanges();
        }

    }
}

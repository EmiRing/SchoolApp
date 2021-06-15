using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public interface ICourseRepository
    {
        IEnumerable<Course> AllCourses { get; }
        Course GetCourseById(int CourseId);
        void AddCourse(Course course);
        void AddStudentsToCourse(int CourseId, IList<Student> students);
    }
}

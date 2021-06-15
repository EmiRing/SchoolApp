using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> AllStudents { get; }
        Student GetStudentById(int Id);
        void AddStudent(Student student);
        void AddCourseToStudent(int studentId, IList<Course> courses);
    }
}

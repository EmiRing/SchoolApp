using Microsoft.AspNetCore.Mvc;
using SchoolApp.ViewModels;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SchoolApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public StudentController(IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public IActionResult ListStudents()
        {
            var students = _studentRepository.AllStudents.OrderBy(s => s.FirstName);
            return View(students);
        }
        [HttpGet]
        public IActionResult DisplayStudent(int StudentId)
        {
            var student = _studentRepository.GetStudentById(StudentId);
            return View(new StudentViewModel
            {
                Student = student,
                Courses = student.Courses
            });
        }


        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {

            _studentRepository.AddStudent(student);
            return RedirectToAction("ListStudents");
        }

        [HttpGet]
        public IActionResult AddCourseToStudent(int studentId)
        {
            return View(new CourseToStudent
            {
                StudentId = studentId,
                Courses = _courseRepository.AllCourses
            });
        }
        [HttpPost]
        public IActionResult AddCourseToStudent(int StudentId, int[] CourseId)
        {
            IList<Course> courses = new List<Course>();
            foreach (var Id in CourseId)
            {
                courses.Add(_courseRepository.GetCourseById(Id));
            }
            _studentRepository.AddCourseToStudent(StudentId, courses);

            return RedirectToAction("DisplayStudent", "Student", new { StudentId = StudentId });
        }
    }
}

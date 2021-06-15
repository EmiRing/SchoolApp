using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;
using SchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly IStudentRepository _studentRepository;


        public CourseController(ICourseRepository courseRepository, ITeacherRepository teacherRepository, IAssignmentRepository assignmentRepository, IStudentRepository studentRepository)
        {
            _teacherRepository = teacherRepository;
            _courseRepository = courseRepository;
            _assignmentRepository = assignmentRepository;
            _studentRepository = studentRepository;
        }

        public ViewResult CourseList()
        {
            IEnumerable<Course> allCourses;

            allCourses = _courseRepository.AllCourses.OrderBy(c => c.CourseName);

            return View(allCourses);
        }


        public IActionResult DisplayCourse(int CourseId)
        {
            var course = _courseRepository.GetCourseById(CourseId);

            if (course == null)
            {
                return NotFound();
            }

            return View(new CourseViewModel
            {
                GetCourse = course,
                GetTeacher = _teacherRepository.GetTeacherById(course.TeacherId),
                Assignments = _assignmentRepository.GetAssignmentsByCourse(course.CourseId)
            });
        }


        [HttpGet]
        public IActionResult AddCourse()
        {
            
            return View(new AddCourseViewModel
            {
                course = null,
                Teachers = _teacherRepository.AllTeachers
            });
        }
        [HttpPost]
        public IActionResult AddCourse(AddCourseViewModel courseListView)
        {

            _courseRepository.AddCourse(courseListView.course);

            return RedirectToAction("CourseList");
        }

        [HttpGet]
        public IActionResult AddStudentsToCourse(int courseId)
        {

            return View(new StudentToCourse
            {
                Students = _studentRepository.AllStudents,
                courseId = courseId
            }) ;
        }
        [HttpPost]
        public IActionResult AddStudentsToCourse(int courseId, int[] StudentId)       
        {
            IList<Student> students = new List<Student>();
            foreach (var Id in StudentId)
            {
                students.Add(_studentRepository.GetStudentById(Id));
            }
            _courseRepository.AddStudentsToCourse(courseId, students);
            return RedirectToAction("DisplayCourse", "Course", new{CourseId = courseId});
            
        }

    }
}

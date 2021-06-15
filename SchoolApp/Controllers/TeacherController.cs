using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IActionResult ListTeachers()
        {
            var teachers = _teacherRepository.AllTeachers.OrderBy(t => t.FirstName);
            return View(teachers);
        }


        [HttpGet]
        public IActionResult AddTeacher()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {

            _teacherRepository.AddTeacher(teacher);
            return RedirectToAction("ListTeachers");
        }
    }
}

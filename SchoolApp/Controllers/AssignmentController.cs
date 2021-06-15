using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;
using SchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public AssignmentController(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;

        }
        [HttpGet]
        public IActionResult AddAssignment(int CourseId)
        {
            Debug.WriteLine(CourseId);
            return View(new Assignment
            {
                CourseId = CourseId
            });
        }

        [HttpPost]
        public IActionResult AddAssignment(Assignment assignment)
        {
            _assignmentRepository.AddAssignment(assignment);
            return RedirectToAction("DisplayCourse","Course", new { CourseId = assignment.CourseId});
        }
    }
}

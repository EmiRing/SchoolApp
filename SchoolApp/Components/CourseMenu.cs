using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Components
{
    public class CourseMenu : ViewComponent
    {
        private readonly ICourseRepository _courseRepository;

        public CourseMenu(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public IViewComponentResult Invoke(string viewName = null)
        {
            var courses = _courseRepository.AllCourses.OrderBy(c => c.CourseName);
            if (!string.IsNullOrEmpty(viewName))
            {
                return View("Sidebar", courses);
            }
            return View(courses);
        }
    }
}

using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.ViewModels
{
    public class CourseViewModel
    {
        public Course GetCourse { get; set; }
        public Teacher GetTeacher { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
       

    }
}

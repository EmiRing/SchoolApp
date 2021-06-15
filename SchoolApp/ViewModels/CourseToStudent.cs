using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.ViewModels
{
    public class CourseToStudent
    {
        public int StudentId { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}

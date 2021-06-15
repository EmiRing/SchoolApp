using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.ViewModels
{
    public class AddCourseViewModel
    {
        public Course course { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        
    }
}

using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.ViewModels
{
    public class StudentToCourse
    {
        public int courseId { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}

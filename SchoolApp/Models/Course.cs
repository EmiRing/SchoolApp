using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }
        

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
       
        public List<Assignment> Assignments { get; set; }

        public List<Student> Students { get; set; }
    }
}

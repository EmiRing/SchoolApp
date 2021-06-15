using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Assignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AssignmentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

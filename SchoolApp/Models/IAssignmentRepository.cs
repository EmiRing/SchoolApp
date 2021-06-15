using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public interface IAssignmentRepository
    {
        IEnumerable<Assignment> AllAssignments { get; }
        IEnumerable<Assignment> GetAssignmentsByCourse(int CourseId);
        void AddAssignment(Assignment assignment);
    }
}

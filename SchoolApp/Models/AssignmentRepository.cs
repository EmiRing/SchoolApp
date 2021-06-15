using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public AssignmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Assignment> AllAssignments => _appDbContext.Assignments;

        public void AddAssignment(Assignment assignment)
        {
            var newAssignment = new Assignment()
            {
                Title = assignment.Title,
                Description = assignment.Description,
                CourseId = assignment.CourseId
            };

            _appDbContext.Assignments.Add(newAssignment);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Assignment> GetAssignmentsByCourse(int CourseId)
        {

            return _appDbContext.Assignments.Where(a => a.CourseId == CourseId);
        }
    }
}

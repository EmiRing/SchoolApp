using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeacherRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Teacher> AllTeachers => _appDbContext.Teachers;

        public Teacher GetTeacherById(int Id)
        {
            return _appDbContext.Teachers.FirstOrDefault(t => t.Id == Id);
        }

        public void AddTeacher(Teacher teacher)
        {
            var newTeacher = new Teacher()
            {
                FirstName = teacher.FirstName,
                LastName = teacher.LastName
            };

            _appDbContext.Teachers.Add(newTeacher);
            _appDbContext.SaveChanges();
        }
    }
}

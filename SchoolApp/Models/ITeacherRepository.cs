using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> AllTeachers { get; }
        Teacher GetTeacherById(int Id);
        void AddTeacher(Teacher teacher);
    }
}

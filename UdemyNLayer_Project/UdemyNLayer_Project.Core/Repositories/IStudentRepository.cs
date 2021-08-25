using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Core.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetWithCoursesByIdAsync(int studentsId); // Öğrenci id'sine göre öğrenci bilgileri ve öğrenciye ait kurslar döner.
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        Task<Course> GetWithInstructorsByIdAsync(int coursesId); // Kurs id'sine göre kurs ve kursun kime ait olduğunu döndürür.
    }
}

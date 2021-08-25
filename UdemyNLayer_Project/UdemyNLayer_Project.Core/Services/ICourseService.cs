using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Core.Services
{
    public interface ICourseService : IService<Course>
    {
        Task<Course> GetWithInstructorsByIdAsync(int coursesId); // Kurs id'sine göre kurs ve kursun kime ait olduğunu döndürür.
    }
}

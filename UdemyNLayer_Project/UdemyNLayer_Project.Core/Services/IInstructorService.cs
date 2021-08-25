using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.Core.Services
{
    public interface IInstructorService : IService<Instructor>
    {
        Task<Instructor> GetWithCoursesByIdAsync(int instructorsId); // Verdiğim id'ye göre eğitmen ve eğitmene ait olan kurslar bana gelicek.
    }
}

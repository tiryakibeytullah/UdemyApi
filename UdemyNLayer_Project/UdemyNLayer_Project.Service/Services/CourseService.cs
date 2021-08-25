using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Core.Repositories;
using UdemyNLayer_Project.Core.Services;
using UdemyNLayer_Project.Core.UnitOfWorks;

namespace UdemyNLayer_Project.Service.Services
{
    public class CourseService : Service<Course>, ICourseService
    {
        public CourseService(IUnitOfWork unitOfWork, IRepository<Course> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Course> GetWithInstructorsByIdAsync(int coursesId)
        {
            return await _unitOfWork.Courses.GetWithInstructorsByIdAsync(coursesId);
        }
    }
}

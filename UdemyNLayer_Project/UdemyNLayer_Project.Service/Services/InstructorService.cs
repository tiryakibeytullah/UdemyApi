using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core;
using UdemyNLayer_Project.Core.Repositories;
using UdemyNLayer_Project.Core.Services;
using UdemyNLayer_Project.Core.UnitOfWorks;

namespace UdemyNLayer_Project.Service.Services
{
    public class InstructorService : Service<Instructor>, IInstructorService
    {
        public InstructorService(IUnitOfWork unitOfWork, IRepository<Instructor> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Instructor> GetWithCoursesByIdAsync(int instructorsId)
        {
            return await _unitOfWork.Instructors.GetWithCoursesByIdAsync(instructorsId);
        }
    }
}

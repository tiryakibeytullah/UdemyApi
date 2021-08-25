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
    public class StudentService : Service<Student>, IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork, IRepository<Student> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Student> GetWithCoursesByIdAsync(int studentsId)
        {
            return await _unitOfWork.Students.GetWithCoursesByIdAsync(studentsId);
        }
    }
}

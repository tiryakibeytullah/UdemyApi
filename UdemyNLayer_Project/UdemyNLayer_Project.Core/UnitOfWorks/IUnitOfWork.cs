using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Repositories;

namespace UdemyNLayer_Project.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        ICourseRepository Courses { get; }
        IInstructorRepository Instructors { get; }
        IStudentRepository Students { get; }
        IOrderRepository Orders { get; }
        Task CommitAsync();
        void Commit();
    }
}

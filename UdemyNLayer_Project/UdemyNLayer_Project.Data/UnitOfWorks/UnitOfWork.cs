using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Repositories;
using UdemyNLayer_Project.Core.UnitOfWorks;
using UdemyNLayer_Project.Data.Repositories;

namespace UdemyNLayer_Project.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private CategoryRepository _categoryRepository;
        private CourseRepository _courseRepository;
        private InstructorRepository _instructorRepository;
        private StudentRepository _studentRepository;
        private OrderRepository _orderRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public ICourseRepository Courses => _courseRepository = _courseRepository ?? new CourseRepository(_context);

        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);

        public IInstructorRepository Instructors => _instructorRepository = _instructorRepository ?? new InstructorRepository(_context);

        public IStudentRepository Students => _studentRepository = _studentRepository ?? new StudentRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

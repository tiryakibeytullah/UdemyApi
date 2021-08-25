using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Core.Repositories;

namespace UdemyNLayer_Project.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public StudentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Student> GetWithCoursesByIdAsync(int studentsId)
        {
            return await _appDbContext.Students.Include(x => x.Courses).SingleOrDefaultAsync(x => x.Id == studentsId);
        }
    }
}

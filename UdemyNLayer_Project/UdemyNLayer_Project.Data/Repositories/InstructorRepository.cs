using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core;
using UdemyNLayer_Project.Core.Repositories;

namespace UdemyNLayer_Project.Data.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public InstructorRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Instructor> GetWithCoursesByIdAsync(int instructorsId)
        {
            return await _appDbContext.Instructors.Include(x => x.Courses).SingleOrDefaultAsync(x => x.Id == instructorsId);
        }
    }
}

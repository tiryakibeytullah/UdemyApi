using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Core.Repositories;

namespace UdemyNLayer_Project.Data.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CourseRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Course> GetWithInstructorsByIdAsync(int coursesId)
        {
            return await _appDbContext.Courses.Include(x => x.Instructors).SingleOrDefaultAsync(x => x.Id == coursesId);
        }
    }
}

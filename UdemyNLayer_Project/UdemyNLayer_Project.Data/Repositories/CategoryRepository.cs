using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Core.Repositories;

namespace UdemyNLayer_Project.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Category> GetWithCoursesByIdAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(x => x.Courses).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithCoursesByIdAsync(int categoryId); // Verilen kategori id'sine göre kategori bilgileri ve o kategoriye ait kurslar döner.
    }
}

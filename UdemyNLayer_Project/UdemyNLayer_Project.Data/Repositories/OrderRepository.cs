using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Core.Repositories;

namespace UdemyNLayer_Project.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public OrderRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Order> GetWithCourseByIdAsync(int orderId)
        {
            return await _appDbContext.Orders.Include(x => x.Courses).SingleOrDefaultAsync(x => x.Id == orderId);
        }

        public async Task<Order> GetWithStudentByIdAsync(int orderId)
        {
            return await _appDbContext.Orders.Include(x => x.Students).SingleOrDefaultAsync(x => x.Id == orderId);
        }
    }
}

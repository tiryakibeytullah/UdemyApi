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
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork, IRepository<Order> repository) : base(unitOfWork, repository)
        {
        }
        public async Task<Order> GetWithCourseByIdAsync(int orderId)
        {
            return await _unitOfWork.Orders.GetWithCourseByIdAsync(orderId);
        }

        public async Task<Order> GetWithStudentByIdAsync(int orderId)
        {
            return await _unitOfWork.Orders.GetWithStudentByIdAsync(orderId);
        }
    }
}

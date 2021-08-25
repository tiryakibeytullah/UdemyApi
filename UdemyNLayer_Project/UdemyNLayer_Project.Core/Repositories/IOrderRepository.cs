using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Core.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetWithStudentByIdAsync(int orderId); // Verilen order id'sine göre order bilgileri ve o order hangi student'a ait onu döner.
        Task<Order> GetWithCourseByIdAsync(int orderId); // Verilen order id'sine göre order bilgileri ve o order hangi course'a ait onu döner.
    }
}

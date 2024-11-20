using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;

namespace eCommerceAPI.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderModel>>GetAllOrderAsync();
        Task<OrderModel> GetOrderByIdAsync(int id);
        // Task<IEnumerable<OrderModel>> GetOrdersByCustomerIdAsync(int customerId);
        Task AddOrderAsync(OrderModel order);
        Task UpdateOrderAsync(OrderModel order);
        Task DeleteOrderAsync(int id);
    }
}
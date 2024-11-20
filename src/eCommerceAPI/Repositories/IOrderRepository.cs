using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;

namespace eCommerceAPI.Repositories
{
    public interface IOrderRepository:IGenericRepository<OrderModel>
    {
        Task<IEnumerable<OrderModel>>GetOrdersByCustomerIdAsync(int UserId);
    }
}
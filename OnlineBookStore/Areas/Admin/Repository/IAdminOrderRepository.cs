using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Areas.Admin.Repository
{
    public interface IAdminOrderRepository
    {
        IEnumerable<Order> AllOrders { get; }
        IEnumerable<OrderDetail> GetOrderDetail(int orderId);
        //int GetTotal(int orderId);
    }
}

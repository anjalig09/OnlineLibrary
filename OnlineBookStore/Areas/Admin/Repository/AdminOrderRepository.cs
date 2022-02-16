using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Areas.Admin.Repository
{
    public class AdminOrderRepository:IAdminOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        public AdminOrderRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Order> AllOrders
        {
            get
            {
                return _appDbContext.Orders;
            }
                
            
        }
        public IEnumerable< OrderDetail> GetOrderDetail(int orderId)
        {
            return _appDbContext.OrderDetails.Where(m=>m.OrderId==orderId);
        }
        //public int GetTotal(int orderId)
        //{
        //    var Total = _appDbContext.OrderDetails.Where(m => m.OrderId == orderId)
        //                                            .Select(m => m.Price * m.Quantity)
        //                                            .Sum();
        //    return (int)Total;
        //}
    }
}

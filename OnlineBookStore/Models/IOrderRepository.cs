using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public interface IOrderRepository
    {
        Order CreateOrder(Order order,string userId);
        void ClearCart(string userId);
    }
}

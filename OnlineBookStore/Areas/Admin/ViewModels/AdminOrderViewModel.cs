using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Areas.Admin.ViewModels
{
    public class AdminOrderViewModel
    {
        public Order Order { get; set; }
        public decimal OrderTotal { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public  OrderDetail OrderDetail { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}

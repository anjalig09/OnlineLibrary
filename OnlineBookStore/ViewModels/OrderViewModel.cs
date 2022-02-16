﻿using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OnlineBookStore.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public decimal OrderTotal { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        //public int Total { get; set; }
    }
}

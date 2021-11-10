﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}

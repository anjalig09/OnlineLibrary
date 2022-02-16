using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.ViewModels;
using OnlineBookStore.Areas.Admin.ViewModels;
using OnlineBookStore.Areas.Admin.Repository;
using OnlineBookStore.Models;

namespace OnlineBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminOrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IAdminOrderRepository _adminOrderRepository;
        public AdminOrderController(IOrderRepository orderRepository,IAdminOrderRepository adminOrderRepository)
        {
            _orderRepository = orderRepository;
            _adminOrderRepository = adminOrderRepository;
        }
        public IActionResult Index()
        {
            OrderViewModel orderViewModel = new OrderViewModel
            {
                Orders = _orderRepository.AllOrders
            };
            return View(orderViewModel);
            //return View();
        }
        public IActionResult Details(int id)
        {
            
            OrderViewModel orderViewModel = new OrderViewModel
            {
                OrderDetails = _adminOrderRepository.GetOrderDetail(id),
                
            };
            return View(orderViewModel);
        }
    }
}

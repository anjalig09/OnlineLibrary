using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
           

        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order,string userId)
        {
            //var items = _shoppingCart.GetShoppingCartItems();
            //_shoppingCart.ShoppingCartItems = items;
            Order newOrder;

            //if (_shoppingCart.ShoppingCartItems.Count == 0)
            //{
            //    ModelState.AddModelError("", "Your cart is empty, Add some Books");
            //}

            if (ModelState.IsValid)
            {
                 newOrder=_orderRepository.CreateOrder(order,userId);
                _shoppingCart.ClearCart(userId);
                return View("CheckoutComplete",new OrderViewModel { order = newOrder, OrderTotal = newOrder.OrderTotal });
            }
            return View(order);
        }

        

        public ViewResult CheckoutComplete(Order order)
        {

            var orderViewModel = new OrderViewModel
            {
                OrderTotal = order.OrderTotal
            };
            return View(orderViewModel);
        }

        public IActionResult PaymentComplete()
        {
            ViewBag.PaymentCompleteMessage = "Thankyou for the order.You will recieve books soon.";
            return View();
        }
    }
}

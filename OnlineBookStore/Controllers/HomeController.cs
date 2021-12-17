using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly AppDbContext _appDbContext;
        public HomeController(IOrderRepository orderRepository,IBookRepository  bookRepository, AppDbContext appDbContext)
        {
            _bookRepository = bookRepository;
            _orderRepository = orderRepository;
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            //var TrendingBooks = _appDbContext.OrderDetails.GroupBy(p => p.BookId).ToList();
            //List<IGrouping<int, OrderDetail>> list = _appDbContext.OrderDetails

            var homeViewModel = new HomeViewModel
            {


                TrendingBooks = _appDbContext.OrderDetails
                                    .Include(e=>e.Book)
                                    .GroupBy (b=>b.BookId)
                                    .Select(e=>new {count=e.Count(),book=e.First().Book})
                                    .OrderByDescending(e=>e.count)
                                    .Take(9)
                                    .Select(e=>e.book)
                                    .ToList()

                

                
            };
            return View(homeViewModel);
            
        }
    }
}

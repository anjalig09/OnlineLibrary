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
        
        //private readonly IOrderRepository _orderRepository;
        private readonly AppDbContext _appDbContext;
        //private readonly IBookRepository _bookRepository;
        public HomeController( AppDbContext appDbContext)
        {
            
            //_orderRepository = orderRepository;
            _appDbContext = appDbContext;
            //_bookRepository = bookRepository;
        }
        public IActionResult Index()
        {

            var homeViewModel = new HomeViewModel
            {


                //TrendingBooks = _appDbContext.OrderDetails
                //                    .Include(e=>e.Book)
                //                    .GroupBy (b=>b.BookId)
                //                    .Select(e=>new {count=e.Count(),book=e.First().Book})
                //                    .OrderByDescending(e=>e.count)
                //                    .Take(9)
                //                    .Select(e=>e.book)
                //                    .ToList()

                //TrendingBooks = _appDbContext.OrderDetails.Include(e => e.Book)
                //                    .GroupBy(p => p.BookId, p => p.Book, (bookId, books) => new { BookId = bookId, Books = books, Count = books.Count() })
                //                    .OrderByDescending(c => c.Count)
                //                    .ToList()
                //                    .Select(e => e.Books.First()).ToList()

                //TrendingBooks = (from db in _appDbContext.OrderDetails group db.Book by db.BookId into g select new { x = g.Key, e = g }).Select(e=>e.),
                //AllBooks = _bookRepository.AllBooks
                TrendingBooks = _appDbContext.OrderDetails
                                    .Include(e => e.Book)
                                    .GroupBy(b => b.BookId)
                                    .Select(e => new { BookId = e.Key, count = e.Count() })
                                    .Join(_appDbContext.Books.Include(i => i.Category), book1 => book1.BookId, book2 => book2.BookId, (book1, book2) => new { Count = book1.count, Book = book2 })
                                    .OrderByDescending(e => e.Count)
                                    .Take(9)
                                    .Select(e => e.Book)
                                    .ToList()

            };
            return View(homeViewModel);
            
        }
    }
}

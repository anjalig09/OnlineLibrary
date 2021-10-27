using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Models;
using OnlineLibrary.ViewModels;

namespace OnlineLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AllBooks = _bookRepository.AllBooks
            };
            return View(homeViewModel);
        }
    }
}

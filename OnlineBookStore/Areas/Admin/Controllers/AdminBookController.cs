using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Areas.Admin.Repository;
using OnlineBookStore.Areas.Admin.ViewModels;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OnlineBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AdminBookController : Controller
    {

        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAdminBookRepository _adminBookRepository;
        private readonly AppDbContext _appDbContext;
        public AdminBookController(IBookRepository bookRepository, IAdminBookRepository adminBookRepository, AppDbContext appDbContext, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
            _adminBookRepository = adminBookRepository;
        }
        public IActionResult Index()
        {
            BooksListViewModel booksListViewModel = new BooksListViewModel
            {
                Books = _bookRepository.AllBooks
            };
            return View(booksListViewModel);
            //return View();
        }
        public IActionResult AddBook()
        {
            AdminBookViewModel adminBookViewModel = new AdminBookViewModel
            {
                CategoriesList=_categoryRepository.AllCategories
            };
            return View(adminBookViewModel);
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            
            _adminBookRepository.AddBook(book);
            BooksListViewModel booksListViewModel = new BooksListViewModel
            {
                Books = _bookRepository.AllBooks
            };
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            AdminBookViewModel adminBookViewModel = new AdminBookViewModel
            {
                Book = _adminBookRepository.EditBook(id),
                CategoriesList = _categoryRepository.AllCategories
            };
            return View(adminBookViewModel);
        }
        [HttpPost]
        public IActionResult Update(Book book,int id)
        {
            _adminBookRepository.UpdateBook(book,id);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            AdminBookViewModel adminBookViewModel = new AdminBookViewModel
            {
                Book = _adminBookRepository.DeleteBook(id),
                CategoriesList = _categoryRepository.AllCategories
            };
            return View(adminBookViewModel);

        }
        public IActionResult Remove(int id)
        {
            _adminBookRepository.RemoveBook(id);
            return RedirectToAction("index");
        }
    }
}

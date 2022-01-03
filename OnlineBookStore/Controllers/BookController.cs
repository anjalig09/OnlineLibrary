using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.ViewModels;
using PagedList;
using PagedList.Core;

namespace OnlineBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        //public string SearchItem { get; set; }
        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List(string searchTerm,int? page,string sort)
        {

            BooksListViewModel booksListViewModel = new BooksListViewModel
            {
                Books = _bookRepository.GetBookBySearchTerm(searchTerm, page,sort)
                
                };
                
                return View(booksListViewModel);    
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        
        
    }
}

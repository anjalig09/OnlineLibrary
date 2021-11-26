using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;


namespace OnlineBookStore.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IShoppingCartRepository _shoppingCart;
        
        public ShoppingCartController(IBookRepository bookRepository, IShoppingCartRepository shoppingCart)
        {
            _bookRepository = bookRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            string userId =User.FindFirstValue(ClaimTypes.NameIdentifier); 



            var items = _shoppingCart.GetShoppingCartItems(userId);
            
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCartItems = items  ,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(userId)
            };
            return View(shoppingCartViewModel);
        }
       
        
        public RedirectToActionResult AddToShoppingCart(int bookId)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var selectedBook = _bookRepository.AllBooks.FirstOrDefault(p => p.BookId == bookId);
           
            
                if (selectedBook != null)
                {
                    _shoppingCart.AddToCart(selectedBook, 1,userId);
                }
                return RedirectToAction("Index");
            
            
           
        }
        public RedirectToActionResult RemoveFromShoppingCart(int bookId,string userId)
        {
            var selectedBook = _bookRepository.AllBooks.FirstOrDefault(p => p.BookId == bookId);
            if (selectedBook != null)
            {
                _shoppingCart.RemoveFromCart(selectedBook,userId);
            }
            return RedirectToAction("Index");
        }
    }
}

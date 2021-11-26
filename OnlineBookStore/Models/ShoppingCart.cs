using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class ShoppingCart:IShoppingCartRepository
    {
        private readonly AppDbContext _appDbContext;
        //public string ShoppingCartId { get; set; }
        //public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //public static ShoppingCart GetCart(IServiceProvider services)
        //{
        //    ISession session = services.GetRequiredService<IHttpContextAccessor>()?
        //        .HttpContext.Session;
        //    var context = services.GetService<AppDbContext>();

        //    string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
        //    session.SetString("CartId", cartId);
        //    return new ShoppingCart(context) { ShoppingCartId = cartId };
        //}
        public  List<ShoppingCartItem> GetShoppingCartItems(string userId)
        {
            var items = _appDbContext.ShoppingCartItems.Include(e=>e.Book).Where(e => e.UserID == userId).ToList();
            return items;
        }
        public void AddToCart(Book book, int quantity,string userId)
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == book.BookId && s.UserID==userId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    Book = book,
                    Quantity = 1,
                    UserID = userId
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Book book,string userId)
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == book.BookId && s.UserID==userId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localAmount = shoppingCartItem.Quantity;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public void RemoveCart(Book book,string userId)
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == book.BookId && s.UserID == userId);
            if (shoppingCartItem != null)
            {
                _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
            }
            _appDbContext.SaveChanges();
        }

        //public List<ShoppingCartItem> GetShoppingCartItems()
        //{
        //    return ShoppingCartItems ??
        //           (ShoppingCartItems =
        //               _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
        //                   .Include(s => s.Book)
        //                   .ToList());
        //}

        public void ClearCart(string userId)
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.UserID == userId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal(string userId)
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.UserID== userId)
                .Select(c => c.Book.Price * c.Quantity).Sum();
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public interface IShoppingCartRepository
    {
         List<ShoppingCartItem> GetShoppingCartItems(string userId);
        void AddToCart(Book book, int quantity, string userId);
         int RemoveFromCart(Book book, string userId);
         void RemoveCart(Book book, string userId);
         void ClearCart(string userId);
         decimal GetShoppingCartTotal(string userId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class OrderRepository:IOrderRepository
    {
        public  decimal OrderTotal;
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            var ShoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach(var shoppingCartItem in ShoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    BookId = shoppingCartItem.Book.BookId,
                    Price = shoppingCartItem.Book.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            

        }
    }
}

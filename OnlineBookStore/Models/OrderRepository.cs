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
        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            //_shoppingCart = shoppingCart;
        }
        public Order CreateOrder(Order order,string userId)
        {
            order.OrderPlaced = DateTime.Now;
            var ShoppingCartItems = _shoppingCart.GetShoppingCartItems(userId);
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal(userId);
            order.OrderDetails = new List<OrderDetail>();
            foreach(var shoppingCartItem in ShoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Quantity = shoppingCartItem.Quantity,
                    BookId = shoppingCartItem.Book.BookId,
                    Price = shoppingCartItem.Book.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            return order;
            

        }
    }
}

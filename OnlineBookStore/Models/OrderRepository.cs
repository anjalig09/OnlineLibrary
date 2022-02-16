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
        private readonly IShoppingCartRepository _shoppingCart;

        public OrderRepository(AppDbContext appDbContext,IShoppingCartRepository shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public IEnumerable<Order> AllOrders
        {
            get
            {
                return _appDbContext.Orders;
            }


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
                    Price = shoppingCartItem.Book.Price,
                    Name=shoppingCartItem.Book.Name,
                    OrderPlaced=order.OrderPlaced,
                    Total= (shoppingCartItem.Book.Price)*(shoppingCartItem.Quantity),
                    
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            return order;
            

        }
        public void ClearCart(string userId)
        {
            _shoppingCart.ClearCart(userId);
        }
    }
}

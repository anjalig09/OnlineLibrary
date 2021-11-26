using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string UserID { get; set; }
    }
}

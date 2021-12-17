using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.ViewModels
{
    public class HomeViewModel
    {
        //public IEnumerable<Book> AllBooks { get; set; }
      
        public OrderDetail OrderDetail { get; set; }
        public IEnumerable<Book> TrendingBooks { get; set; }
    }
}

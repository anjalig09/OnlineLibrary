using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Models;

namespace OnlineLibrary.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> AllBooks { get; set; }
    }
}

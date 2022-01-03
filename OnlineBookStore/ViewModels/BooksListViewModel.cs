using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

using PagedList;
using PagedList.Core;
namespace OnlineBookStore.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string CurrentCategory { get; set; }
        public string SearchTerm { get; set; }
        public int? Page { get; set; }
        public int PageNo { get; }
        public string PriceSort { get; set; }

    }
}

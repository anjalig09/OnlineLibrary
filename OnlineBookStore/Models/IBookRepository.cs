using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> AllBooks { get; }
        //IEnumerable<Book> SortingBooks(string sort);
        Book GetBookById(int bookId);
        IEnumerable<Book> GetBookBySearchTerm(string searchTerm,int? page,string sort);
        int PageCount();
    }
}

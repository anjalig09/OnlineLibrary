using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> AllBooks { get; }
        Book GetBookById(int bookId);
    }
}

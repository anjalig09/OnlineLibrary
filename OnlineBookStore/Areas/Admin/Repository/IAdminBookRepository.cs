using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Areas.Admin.Repository
{
    public interface IAdminBookRepository
    {
        void AddBook(Book book);
        Book EditBook(int bookId);
        void UpdateBook( Book book,int bookId);
        Book DeleteBook(int bookId);
        void RemoveBook(int bookId);
    }
}

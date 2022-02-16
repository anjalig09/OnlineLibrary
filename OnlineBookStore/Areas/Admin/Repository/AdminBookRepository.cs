using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;
using OnlineBookStore.Areas.Admin.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Areas.Admin.Repository
{
    public class AdminBookRepository:IAdminBookRepository
    {
        private readonly AppDbContext _appDbContext;
        //private readonly AddBookRepository _addBookRepository;
        public AdminBookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddBook(Book book)
        {
            var books = _appDbContext.Books.Select(b => b.Name==book.Name).Any();
            if (books == true)
            {
                _appDbContext.Books.Add(book);
                _appDbContext.SaveChanges();
            }
            
            
        }
        public Book EditBook(int bookId)
        {
           
            return _appDbContext.Books.FirstOrDefault(p => p.BookId == bookId);

        }
        public void UpdateBook(Book book,int bookId)
        {

            _appDbContext.Books.Update(book);
            _appDbContext.SaveChanges();
            
        }
        public Book DeleteBook(int bookId)
        {
            return _appDbContext.Books.FirstOrDefault(p => p.BookId == bookId);
        }
        public void RemoveBook(int bookId)
        {

            var localBook=_appDbContext.Books.FirstOrDefault(m => m.BookId == bookId);
            localBook.IsDeleted = true;
            _appDbContext.Books.Update(localBook);
            _appDbContext.SaveChanges();

            //return book;
            //return _appDbContext.Books.Where(m => m.IsDeleted == false);
        }
        
       
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Core;

namespace OnlineBookStore.Models
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _appDbContext;
       
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> AllBooks
        {
            get
            {
                return _appDbContext.Books.Include(c => c.Category);
            }
        }
        public Book GetBookById(int bookId)
        {
            return _appDbContext.Books.Include(e=>e.Category).FirstOrDefault(p => p.BookId == bookId);
        }
        public IEnumerable<Book> GetBookBySearchTerm(string searchTerm,int? page)
        {
            
            if (searchTerm != null)
            {

                 
                
                return _appDbContext.Books.Include(e => e.Category).Where(s => s.Name.Contains(searchTerm) ||
                                                       s.AuthorName.Contains(searchTerm) ||
                                                       s.Category.CategoryName.Contains(searchTerm)).ToPagedList(page ?? 1, 9);
                                                  
            }
            else
            {

               
                return AllBooks.ToPagedList(page?? 1,9);
            }
        }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(_appDbContext.Books.Count() / (double)9));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Core;
using OnlineBookStore.ViewModels;

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
        public IEnumerable<Book> GetBookBySearchTerm(string searchTerm,int? page,string priceSort)
        {
            
            if (searchTerm != null)
            {

                return _appDbContext.Books.Include(e => e.Category).Where(s => s.Name.Contains(searchTerm) ||
                                                       s.AuthorName.Contains(searchTerm) ||
                                                       s.Category.CategoryName.Contains(searchTerm)).OrderBy(b => b.Price).ToPagedList(page ?? 1, 9);
                                                  
            }

            
            switch (priceSort)
            {
                case "PriceLow":
                    return AllBooks.OrderBy(b => b.Price);
                    
                case "PriceHigh":
                    return AllBooks.OrderByDescending(b => b.Price);
                    
                default:
                    return AllBooks.OrderBy(b => b.BookId);
                    
            }
            //return sort switch
            //{
            //    PriceLow => AllBooks.OrderBy(b => b.Price),
            //    PriceHigh => AllBooks.OrderByDescending(b => b.Price),
            //    _ => AllBooks.OrderBy(b => b.BookId),
            //};
        }
        //public IEnumerable<Book> SortingBooks(string sort) { }
        public int PageCount()
        {
            int pageNo= (int)(Math.Ceiling((decimal)_appDbContext.Books.Count() / 9));
            return pageNo;
        }
    }
}

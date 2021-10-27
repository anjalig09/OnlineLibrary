using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class MockBookRepository:IBookRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Book> AllBooks =>
            new List<Book>
            {
                new Book{BookId=1,Name="Tom and jerry",AuthorName="Joseph barbera",Price=400,ShortDescription="Lorem Ipsum",LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://cartoonresearch.com/wp-content/uploads/2017/05/tj1.jpg",InStock=true},
                new Book{BookId=2,Name="Harry Potter",AuthorName="J.K rowling",Price=1000,ShortDescription="Lorem Ipsum",LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    Category=_categoryRepository.AllCategories.ToList()[1],ImageUrl="https://www.wizardingworld.com/_next/image?url=%2Fimages%2Fproducts%2Fbooks%2FUK%2Frectangle-1.jpg&w=1920&q=75",InStock=true},
                new Book{BookId=3,Name="A tale of two cities",AuthorName="Charles Dickens",Price=800,ShortDescription="Lorem Ipsum",LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    Category=_categoryRepository.AllCategories.ToList()[2],ImageUrl="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.kobo.com%2Fgr%2Fen%2Febook%2Fa-tale-of-two-cities-330&psig=AOvVaw3P_W9nV2LwFey5vDhMaTr9&ust=1634711530389000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNDIxpzt1fMCFQAAAAAdAAAAABAD",
                    InStock=true}
            };
        public Book GetBookById(int bookId)
        {
            return AllBooks.FirstOrDefault(p => p.BookId == bookId);
        }

    }
}

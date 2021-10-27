using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cartoon" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fantasy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Novel" });

            //seed pies

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Name = "Tom and jerry",
                AuthorName = "Joseph barbera",
                Price = 400,
                ShortDescription = "Lorem Ipsum",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. ",
                CategoryId = 1,
                ImageUrl = "https://cartoonresearch.com/wp-content/uploads/2017/05/tj1.jpg",
                InStock = true,

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Name = "Harry Potter",
                AuthorName = "J.K Rowling",
                Price = 1000,
                ShortDescription = "Lorem Ipsum",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                CategoryId = 2,
                ImageUrl = "https://www.wizardingworld.com/_next/image?url=%2Fimages%2Fproducts%2Fbooks%2FUK%2Frectangle-1.jpg&w=1920&q=75",
                InStock = true,

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Name = "A tale of two cities",
                AuthorName = "Charles Dickens",
                Price = 250,
                ShortDescription = "Lorem Ipsum",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                CategoryId = 3,
                ImageUrl = "https://images1.penguinrandomhouse.com/cover/9780451530578",
                InStock = true,

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Name = "The God of Small Things",
                AuthorName = "Arundhati Roy",
                Price = 800,
                ShortDescription = "Lorem Ipsum",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                CategoryId = 3,
                ImageUrl = "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/9/2/1441203713652/0bf35fbc-b649-4290-bf76-f1bdcc631bb6-399x600.jpeg?width=140&quality=85&auto=format&fit=max&s=fdc80d9419c7f6cea190503c556a39be",
                InStock = true,

            });
        }
    }
}

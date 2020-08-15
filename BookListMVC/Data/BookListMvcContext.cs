using System;
using Microsoft.EntityFrameworkCore;
using BookListMVC.Models;
namespace BookListMVC.Data
{
    public class BookListMvcContext : DbContext
    {
        public BookListMvcContext(DbContextOptions<BookListMvcContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}

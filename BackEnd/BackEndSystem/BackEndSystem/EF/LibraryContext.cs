using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndSystem.EF
{
    public class LibraryContext : DbContext
    {
        public DbSet<BookList> BookList { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<ContactUs> ContactUs { get; set;}
    }
}

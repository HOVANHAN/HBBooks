using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HBBooks.Models;

    public class HBBooksContext : DbContext
    {
        public HBBooksContext (DbContextOptions<HBBooksContext> options)
            : base(options)
        {
        }

        public DbSet<HBBooks.Models.Book> Book { get; set; } = default!;
    }

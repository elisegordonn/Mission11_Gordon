﻿using Microsoft.EntityFrameworkCore;
namespace Mission11_Gordon.Models;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
}

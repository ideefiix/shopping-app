using Microsoft.EntityFrameworkCore;
using System;

namespace ShoppingAPI.Models.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}

        public DbSet<ShoppingItem> ShoppingItems { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}

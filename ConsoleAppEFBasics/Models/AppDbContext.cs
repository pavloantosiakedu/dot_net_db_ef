using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleAppEFBasics.Models
{
    internal class AppDbContext: DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }//=> Set<User>();
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=appefbasicsdb;Trusted_Connection=True;");
        }
    }
}

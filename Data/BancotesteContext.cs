using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVC_test.Models
{
    public partial class BancotesteContext : DbContext
    {
 
        public BancotesteContext()
        {
        }

        public BancotesteContext(DbContextOptions<BancotesteContext> options)
            : base(options)
        {
        }

        public DbSet<Produtos> Products {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=novodb;Uid=Developer;Pwd=123456789;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}

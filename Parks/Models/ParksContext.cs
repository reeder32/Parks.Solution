using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           
        }

        public DbSet<Park> Parks { get; set; }

    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

      
   

    }
    }
}
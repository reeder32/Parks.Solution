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
        protected override void OnModelCreating(ModelBuilder builder)
        {
      builder.Entity<Park>()
      .HasData(
        new Park
        {
          ParkId = 1,
          Name = "Olympic National Park",
          State = "Washington",
          City = "Port Angeles",
          ZipCode = 98362,
          Type = "National"
        });
    }
    }
}
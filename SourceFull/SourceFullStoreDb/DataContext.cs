using System;
using Domain;
using Microsoft.EntityFrameworkCore;


namespace SourceFullStoreDb
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        {            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Member>()
                .HasData(
                    new Member { Id = 1, Name = "Adam", Surname = "Backers" },
                    new Member { Id = 2, Name = "Davis", Surname = "Clarck" },
                    new Member { Id = 3, Name = "Frank", Surname = "Evans" },
                    new Member { Id = 4, Name = "Irwin", Surname = "Jones" },
                    new Member { Id = 5, Name = "Troth", Surname = "Smith" }
                );
                builder.Entity<City>()
                    .HasData(
                        new City { Id = 1, Name = "Kielce", Size = 250000 },
                        new City { Id = 2, Name = "Łódź", Size = 550000 },
                        new City { Id = 4, Name = "Lublin", Size = 450000 },
                        new City { Id = 5, Name = "Końskie", Size = 780000 },
                        new City { Id = 6, Name = "Warszawa", Size = 21250000 }
                    );
        }
    }
}
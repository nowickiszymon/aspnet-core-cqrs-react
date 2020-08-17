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
                    new Member { Id = 1, Name = "Szymon", Surname = "Nowutyuicki" },
                    new Member { Id = 2, Name = "Szymoasdas", Surname = "Nutyowicki" },
                    new Member { Id = 3, Name = "Szydasdmon", Surname = "Noutyuwicki" },
                    new Member { Id = 4, Name = "Szeerewymon", Surname = "Notyutwicki" },
                    new Member { Id = 5, Name = "Szymbvcbon", Surname = "Nowityutcki" },
                    new Member { Id = 6, Name = "Szymbvcbon", Surname = "Nowutyuicki" },
                    new Member { Id = 7, Name = "Szymhgjghon", Surname = "Notyutwicki" },
                    new Member { Id = 8, Name = "Szymjghjgon", Surname = "Nowiutyucki" }
                );
                builder.Entity<City>()
                    .HasData(
                        new City { Id = 1, Name = "Kielce", Size = 250000 },
                        new City { Id = 2, Name = "Łódź", Size = 550000 },
                        new City { Id = 3, Name = "Lublin", Size = 450000 }
                    );
        }
    }
}
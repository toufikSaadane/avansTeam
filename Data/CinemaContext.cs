using System;
using avansTeam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace avansTeam.Data
{
    public class CinemaContext : IdentityDbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Performance> Performances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(FakeData.FakeMovie);
            modelBuilder.Entity<Hall>().HasData(FakeData.FakeHall);
            modelBuilder.Entity<Performance>().HasData(FakeData.FakePerformance);
        }
    }
}

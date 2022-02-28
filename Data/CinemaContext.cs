using System;
using Microsoft.EntityFrameworkCore;

namespace avansTeam.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }
    }
}

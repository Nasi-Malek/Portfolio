using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System.Collections.Generic;

namespace Portfolio.Api.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
            : base(options)
        {
        }


        public DbSet<Project> Projects { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}

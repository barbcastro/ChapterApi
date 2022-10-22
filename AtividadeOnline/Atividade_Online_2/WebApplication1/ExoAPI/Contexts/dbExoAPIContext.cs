using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class dbExoAPIContext : DbContext
    {
        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = BARBARA-CASTRO\\SQLEXPRES; initial catalog = dbExoAPI,");
            }
        }

        public DbSet<Projeto> Projetos { get; set; } 
    }
}

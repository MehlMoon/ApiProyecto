using ApiProyecto.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProyecto.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet <usuarios> usuarios { get; set; }

    }
}
 
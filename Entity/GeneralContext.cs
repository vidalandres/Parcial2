using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Entity;

namespace Entity
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options)
        {
            
        }

        public DbSet<Persona> Personas { get; set;}
        public DbSet<Apoyo> Apoyos { get; set; }
    }
}
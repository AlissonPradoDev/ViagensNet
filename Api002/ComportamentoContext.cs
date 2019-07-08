using Microsoft.EntityFrameworkCore;

namespace Api002.Models
{
    public class ComportamentoDContext : DbContext
    {
        public DbSet<Visitante> Visitantes { get; set; }

        public ComportamentoDbContext()
        {

        }

        public ComportamentoDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Api002.Models
{
    public class ComportamentoDbContext : DbContext
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

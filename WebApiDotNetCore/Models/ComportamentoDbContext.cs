using Microsoft.EntityFrameworkCore;

namespace WebApiDotNetCore.Models
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

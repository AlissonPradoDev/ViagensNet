using Api001.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api001.Data
{
    public class ComportamentoContext : DbContext
    {
        public ComportamentoContext(DbContextOptions options) : base(options);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Comportamentos> Comportamentos { get; set }
 
    }
}

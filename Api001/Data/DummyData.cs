using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api001.Data
{
    public class DummyData
    {
        public static void Initialize (IApplicationBuilder app)
        {
            using (var serviceScope =app.ApplicationServices.GetService<IserviceScopeFactory>().CreateScope)
        } 
        public static List<Comportamentos> GetComportamentos()
        {
            List<Comportamento> comportamentos = new List<Comportamento>()
            {
                new Comportamento {Title="Alisson", Navegador = "Safari", Identificador = "192.168.1.100"}
            };
        }
    }

    internal class Comportamento
    {
        public string Title { get; set; }
        public string Navegador { get; set; }
        public string Identificador { get; set; }
    }
}

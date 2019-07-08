using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api001.Models
{
    public class Comportamentos
    {
        [key]
        public string Title { get; set; }
        public string Navegador { get; set; }
        public string identificador { get; set; }

    }
}

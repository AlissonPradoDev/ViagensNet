using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    public class VisitanteController : Controller
    {

        private readonly ComportamentoDbContext _db;

        public VisitanteController(ComportamentoDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Visitante> Get()
        {
            return _db.Visitantes.ToList();
        }

        [HttpGet("{id}")]
        public Visitante Get(int id)
        {
            return _db.Visitantes.Find(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Visitante obj)
        {
            _db.Visitantes.Add(obj);
            _db.SaveChanges();
            return new ObjectResult("Comportamento adicionado com sucesso!");

        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Visitante obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            return new ObjectResult("Comportamento alterado com sucesso!");
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _db.Visitantes.Remove(_db.Visitantes.Find(id));
            _db.SaveChanges();
            return new ObjectResult("Comportamento excluido com sucesso!");
        }
    }
}

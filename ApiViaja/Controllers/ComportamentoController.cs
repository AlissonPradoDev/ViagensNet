using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiViaja.Controllers
{
    [Produces("application/json")]
    [Route("api/comportamento")]
    public class ComportamentoController : Controller
    {

        string[] days = {'Sun','Mon','Tue'};
        // GET: api/Comportamento
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return days;
        }

        // GET: api/Comportamento/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Comportamento
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Comportamento/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

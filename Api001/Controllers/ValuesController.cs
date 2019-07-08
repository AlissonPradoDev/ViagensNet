using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api001.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        string[] days = { "Seg", "Ter", "Qua" };
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return days;
        }

        // GET api/values/5 --> Alisson Prado coça numero 12500000 milhoes ^e kkkk
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id > -1 && id < days.Count())
                return days[id];
            else
                return "Não amola. Vc tá dando overflow no array";
        }

        // POST api/values --> Associado a inserir Dados 
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

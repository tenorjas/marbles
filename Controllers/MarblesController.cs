using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using marbles.Models;

namespace marbles.Controllers
{
    [Route("api/[controller]")]
    public class MarblesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var marble = new MarblesModel();
            Random rnd = new Random();
            int marbleColorIndex = rnd.Next(0,marble.colors.Count());
            return $"color: {marble.colors[marbleColorIndex]}";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
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

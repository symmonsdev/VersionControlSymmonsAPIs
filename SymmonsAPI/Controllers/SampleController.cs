﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SymmonsAPI.Controllers
{
    //[Authorize]
    [Route("/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        // GET: api/<SampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            if (User.Identity.IsAuthenticated)
            {
                return new string[] { "value1", "value2" };
            }
            else { 
                return new string[] { "Denied" };
            }
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id == 1) { 
               return "value";
            }
            else
            {
                return "Not one";
            }
        }

        // POST api/<SampleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

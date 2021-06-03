using AspNetCore.Study.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Study.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonumentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome");
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok($"Returning id: {id}");
        }

        [HttpPost]
        public IActionResult Create(Monument monument)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Monument monument)
        {
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting id: {id}");
        }
    }
}

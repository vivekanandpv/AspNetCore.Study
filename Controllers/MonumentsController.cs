using AspNetCore.Study.Models;
using AspNetCore.Study.Services;
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
        private readonly IMonumentService _service;

        public MonumentsController(IMonumentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpPost]
        public IActionResult Create(Monument monument)
        {
            _service.Create(monument);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Monument monument)
        {
            _service.Update(monument);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}

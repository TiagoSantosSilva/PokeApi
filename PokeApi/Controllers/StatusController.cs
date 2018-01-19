using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly DatabaseContext _context;

        public StatusController(DatabaseContext context) 
        {
            _context = context;

            if(_context.Status.Count() == 0)
            {
                _context.InitializeDatabase();
            }
        }

        [HttpGet]
        public IEnumerable<Status> GetAll()
        {
            return _context.Status.ToList();
        }

        [HttpGet("{id}", Name = "GetStatus")]
        public IActionResult GetById(long id)
        {
            var item = _context.Status.FirstOrDefault(s => s.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Status item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Status.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetStatus", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Status item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var status = _context.Status.FirstOrDefault(t => t.Id == id);
            if (status == null)
            {
                return NotFound();
            }

            status.Code = item.Code;
            status.Description = item.Description;

            _context.Status.Update(status);
            _context.SaveChanges();
            return CreatedAtRoute("GetStatus", new { id = item.Id }, item);
        }
    }
}

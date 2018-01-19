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
    }
}

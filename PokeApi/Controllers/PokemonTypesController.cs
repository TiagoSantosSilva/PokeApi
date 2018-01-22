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
    public class PokemonTypesController : Controller
    {
        private readonly DatabaseContext _context;

        public PokemonTypesController(DatabaseContext context)
        {
            _context = context;

            if (_context.Types.Count() == 0)
            {
                _context.InitializeDatabase();
            }
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<PokemonType> Get()
        {
            return _context.Types.ToList();
        }
    }
}

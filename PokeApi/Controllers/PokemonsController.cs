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
    public class PokemonsController : Controller
    {
        private readonly DatabaseContext _context;

        public PokemonsController(DatabaseContext context)
        {
            _context = context;

            if (_context.Pokemons.Count() == 0)
            {
                _context.InitializeDatabase();
            }
        }

        [HttpGet]
        public IEnumerable<PokemonDTO> GetAll()
        {
            var pokemons = from p in _context.Pokemons
                           select new PokemonDTO()
                           {
                               Id = p.Id,
                               Name = p.Name,
                               DexNumber = p.DexNumber
                           };

            return pokemons;
        }

        [HttpGet("{id}", Name = "GetPokemon")]
        public IActionResult GetById(long id)
        {
            var item = _context.Pokemons.FirstOrDefault(p => p.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Pokemon item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Pokemons.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetPokemon", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Pokemon item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var pokemon = _context.Pokemons.FirstOrDefault(p => p.Id == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            pokemon.DexNumber = item.DexNumber;
            pokemon.Name = item.Name;
            pokemon.Height = item.Height;
            pokemon.Weight = item.Weight;

            _context.Pokemons.Update(pokemon);
            _context.SaveChanges();
            return CreatedAtRoute("GetPokemon", new { id = item.Id }, item);
        }
    }
}

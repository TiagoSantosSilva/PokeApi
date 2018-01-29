using System;
using Microsoft.EntityFrameworkCore;

namespace PokeApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> Types { get; set; }

        public void InitializeDatabase() 
        {
            Types.Add(new PokemonType { Type = "Fire" }); 
            Types.Add(new PokemonType { Type = "Ghost" }); 
            Types.Add(new PokemonType { Type = "Grass" }); 
            Types.Add(new PokemonType { Type = "Poison" }); 
            Types.Add(new PokemonType { Type = "Rock" }); 
            Types.Add(new PokemonType { Type = "Water" });

            Pokemons.Add(new Pokemon
            {
                DexNumber = 001,
                Name = "Bulbasaur",
                Height = 0.7F,
                Weight = 6.9F,
                Type = "Grass"
            });

            Pokemons.Add(new Pokemon
            {
                DexNumber = 002,
                Name = "Ivysaur",
                Height = 1.0F,
                Weight = 13.0F,
                Type = "Grass"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 003,
                Name = "Venusaur",
                Height = 2.0F,
                Weight = 100.0F,
                Type = "Grass"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 004,
                Name = "Charmander",
                Height = 0.6F,
                Weight = 8.5F,
                Type = "Fire"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 005,
                Name = "Charmeleon",
                Height = 1.1F,
                Weight = 19.0F,
                Type = "Fire"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 006,
                Name = "Charizard",
                Height = 1.7F,
                Weight = 90.5F,
                Type = "Fire"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 007,
                Name = "Squirtle",
                Height = 0.5F,
                Weight = 9F,
                Type = "Water"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 008,
                Name = "Wartortle",
                Height = 1.0F,
                Weight = 22.5F,
                Type = "Water"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 009,
                Name = "Blastoise",
                Height = 1.6F,
                Weight = 85.5F,
                Type = "Water"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 722,
                Name = "Rowlet",
                Height = 0.3F,
                Weight = 1.5F,
                Type = "Grass"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 723,
                Name = "Dartrix",
                Height = 0.7F,
                Weight = 16.0F,
                Type = "Grass"
            });
            Pokemons.Add(new Pokemon
            {
                DexNumber = 724,
                Name = "Decidueye",
                Height = 1.6F,
                Weight = 36.6F,
                Type = "Grass"
            });

            Status.Add(new Status { Code = 200, Description = "API is up." });
            Status.Add(new Status { Code = 500, Description = "API is down." });
            SaveChanges();
        }
    }
}

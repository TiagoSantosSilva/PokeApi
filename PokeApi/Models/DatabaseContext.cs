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

        public void InitializeDatabase() 
        {
            this.Status.Add(new Status { Code = 200, Description = "API is up." });
            this.Status.Add(new Status { Code = 500, Description = "API is down." });

            this.Pokemons.Add(new Pokemon { DexNumber = 001, Name = "Bulbasaur", Height = 0.7F, Weight = 6.9F });
            this.Pokemons.Add(new Pokemon { DexNumber = 002, Name = "Ivysaur", Height = 1.0F, Weight = 13.0F });
            this.Pokemons.Add(new Pokemon { DexNumber = 003, Name = "Venusaur", Height = 2.0F, Weight = 100.0F });
            this.Pokemons.Add(new Pokemon { DexNumber = 004, Name = "Charmander", Height = 0.6F, Weight = 8.5F });
            this.Pokemons.Add(new Pokemon { DexNumber = 005, Name = "Charmeleon", Height = 1.1F, Weight = 19.0F });
            this.Pokemons.Add(new Pokemon { DexNumber = 006, Name = "Charizard", Height = 1.7F, Weight = 90.5F });
            this.Pokemons.Add(new Pokemon { DexNumber = 007, Name = "Squirtle", Height = 0.5F, Weight = 9F });
            this.Pokemons.Add(new Pokemon { DexNumber = 008, Name = "Wartortle", Height = 1.0F, Weight = 22.5F });
            this.Pokemons.Add(new Pokemon { DexNumber = 009, Name = "Blastoise", Height = 1.6F, Weight = 85.5F });
            this.Pokemons.Add(new Pokemon { DexNumber = 722, Name = "Rowlet", Height = 0.3F, Weight = 1.5F });
            this.Pokemons.Add(new Pokemon { DexNumber = 723, Name = "Dartrix", Height = 0.7F, Weight = 16.0F });
            this.Pokemons.Add(new Pokemon { DexNumber = 724, Name = "Decidueye", Height = 1.6F, Weight = 36.6F });
            this.SaveChanges();
        }
    }
}

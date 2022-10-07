using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace MyPokeAPI.Models
{
    public class MyPokemonContext : DbContext
    {
        public MyPokemonContext(DbContextOptions<MyPokemonContext> options) : base(options)
        { }

        public DbSet<MyPokemon> MyPokemons { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

using System.Diagnostics.CodeAnalysis;

namespace MyPokeAPI.Models
{
    public class MyPokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public int UserId { get; set; }
        //public virtual User User { get; set; }
    }
}

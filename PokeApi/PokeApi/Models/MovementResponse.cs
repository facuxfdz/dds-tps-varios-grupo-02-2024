namespace PokeApi.Models;

public class MovementResponse
{
    public List<LearnedByPokemon> learned_by_pokemon { get; set; }
    
    public class LearnedByPokemon
    {
        public string name { get; set; }
    }
}
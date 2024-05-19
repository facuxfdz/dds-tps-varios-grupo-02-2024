using Newtonsoft.Json;
using PokeApi.Entities;
using PokeApi.Models;
using RestSharp;

namespace PokeApi.Infrastructure;

public class PokeApiRest
{
    private readonly string _url = "https://pokeapi.co/api/v2/";
    
    public Pokemon GetPokemon(string name)
    {
        var client = new RestClient(_url);
        var request = new RestRequest($"pokemon/{name}", Method.Get);
        var response = client.Execute(request);
        var pokemonResponse = JsonConvert.DeserializeObject<PokemonResponse>(response.Content);
        return new Pokemon
        {
            Nombre = pokemonResponse.name,
            Orden = pokemonResponse.order,
            ArteOficialUrl = pokemonResponse.sprites.other.officialartwork.front_default,
            Movimientos = pokemonResponse.moves.Select(m => new Movimiento{Nombre = m.move.name}).ToList()
        };
    }
    
    public List<Pokemon> GetPokemonesConMovimiento(string name)
    {
        var client = new RestClient(_url);
        var request = new RestRequest($"move/{name}", Method.Get);
        var response = client.Execute(request);
        var movementResponse = JsonConvert.DeserializeObject<MovementResponse>(response.Content);
        return movementResponse.learned_by_pokemon.Select(p => new Pokemon
        {
            Nombre = p.name,
        }).ToList();
    }
}
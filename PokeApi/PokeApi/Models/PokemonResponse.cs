using Newtonsoft.Json;

namespace PokeApi.Models;

public class PokemonResponse
{
    public List<Move> moves { get; set; }
    public string name { get; set; }
    public int order { get; set; }
    public Sprites sprites { get; set; }
    
    public class Move
    {
        public Move2 move { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
    }

    public class Other
    {
        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }
    }

    public class Sprites
    {
        public Other other { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace APIPokemon.Models;

public class MascoteDetails
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("abilities")]
    public List<AbilityDetails> ? Abilities { get; set; } 

    public void Info()
    {
        Console.WriteLine($"Pokémon escolhido: {Name}");
        Console.WriteLine($"Tamanho: {Height}");
        Console.WriteLine($"Peso: {Weight}");
            
    }

   
}

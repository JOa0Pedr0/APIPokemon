using System.Text.Json.Serialization;

namespace APIPokemon.Models;

public class Mascote
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    
}

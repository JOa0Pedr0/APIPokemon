using System.Text.Json.Serialization;

namespace APIPokemon.Models;

public class Ability
{
    [JsonPropertyName("name")]
    public string ? Name { get; set; }

    [JsonPropertyName("url")]
    public string ? url { get; set; } 
}

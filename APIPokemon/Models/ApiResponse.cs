using System.Text.Json.Serialization;

namespace APIPokemon.Models;

public class ApiResponse
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; } = null!;

    [JsonPropertyName("previous")]
    public string Previous { get; set; } = null!;

    [JsonPropertyName("results")]
    public List<Mascote> Results { get; set; } = null!;
}

using System.Text.Json.Serialization;

namespace APIPokemon.Models;

public class AbilityDetails
{
    [JsonPropertyName("ability")]

    public Ability ? Ability { get; set; }

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("slot")]
    public int Slot { get; set; }
}

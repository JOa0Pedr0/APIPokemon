

using APIPokemon.Models;
using Newtonsoft.Json;
using System.Linq.Expressions;

public class Program
{
    static async Task Main(string[] args)
    {
        int escolha;
        string url = "https://pokeapi.co/api/v2/pokemon";
        using(HttpClient client = new HttpClient())
        {
            try
            {
                Console.WriteLine("Obtendo Resultado...");

                var response = await client.GetStringAsync(url);
                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(response)!;
                Console.WriteLine($"\nPokémons:");

                for (int i = 0; i < apiResponse.Results.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{apiResponse.Results[i].Name}");
                }
                Console.WriteLine("\nEscolha um dos pokémon:");
                while (true)
                {
                    escolha = int.Parse(Console.ReadLine()!);
                    if (escolha > apiResponse.Results.Count || escolha < 1)
                    {
                        Console.WriteLine("Tente novamente!");
                    }

                    else
                        break;
                }
                Console.Clear();

                var pokemondetailsresponse = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{escolha}");
                MascoteDetails mascoteDetails = JsonConvert.DeserializeObject<MascoteDetails>(pokemondetailsresponse)!;
                mascoteDetails.Info();
                Console.WriteLine($"Habilidades:");

                foreach (var ability in mascoteDetails.Abilities!)
                {
                  
                    Console.WriteLine($"-{ability.Ability!.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
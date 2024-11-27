using RestSharp;
using System;
using System.Reflection.Metadata.Ecma335;
internal class Program
{
    private static void Main(string[] args)
    {
        var client = new RestClient($"https://pokeapi.co/api/v2/");

        var request = new RestRequest("pokemon", Method.Get);

        var response = client.Execute(request);
        try
        {
            Console.WriteLine(response.Content);

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
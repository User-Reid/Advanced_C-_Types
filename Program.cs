using System.Text.Json;
using System.Text.Json.Serialization;

IClient client = new Client();
var baseAddress = "https://swapi.info/api/";
var requestUri = "planets";

var json = await client.Read(baseAddress, requestUri);
var root = JsonSerializer.Deserialize<List<Root>>(json);

foreach (var planet in root)
{
  System.Console.WriteLine($"Planet: {planet.name}, Climate: {planet.climate}");
}

Console.ReadKey();

public interface IClient
{
  Task<string> Read(string baseAddress, string requestUri);
}

public class Client : IClient
{
  public async Task<string> Read(string baseAddress, string requestUri)
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri(baseAddress);
    var response = await client.GetAsync(requestUri);
    response.EnsureSuccessStatusCode();

    return await response.Content.ReadAsStringAsync();
  }
}

    public record Root(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("rotation_period")] string rotation_period,
        [property: JsonPropertyName("orbital_period")] string orbital_period,
        [property: JsonPropertyName("diameter")] string diameter,
        [property: JsonPropertyName("climate")] string climate,
        [property: JsonPropertyName("gravity")] string gravity,
        [property: JsonPropertyName("terrain")] string terrain,
        [property: JsonPropertyName("surface_water")] string surface_water,
        [property: JsonPropertyName("population")] string population,
        [property: JsonPropertyName("residents")] IReadOnlyList<string> residents,
        [property: JsonPropertyName("films")] IReadOnlyList<string> films,
        [property: JsonPropertyName("created")] DateTime created,
        [property: JsonPropertyName("edited")] DateTime edited,
        [property: JsonPropertyName("url")] string url
    );
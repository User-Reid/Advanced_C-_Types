// using System.Text.Json.Serialization;
// using System.Text.Json;

// var baseAddress = "https://swapi.info/api/";
// var requestUri = "planets";

// IApiDataReader apiDataReader = new ApiDataReader();
// var json = await apiDataReader.Read(baseAddress, requestUri);

// var root = JsonSerializer.Deserialize<List<Root>>(json);
// foreach (var planet in root)
// {
//   System.Console.WriteLine($"Planet {planet.name}, Population Size: {planet.population}");
// }

// Console.ReadKey();

// public interface IApiDataReader
// {
//   Task<string> Read(string baseAddress, string requestUri);
// }

// public class ApiDataReader : IApiDataReader
// {

//   public async Task<string> Read(string baseAddress, string requestUri)
//   {
//     var client = new HttpClient();
//     client.BaseAddress = new Uri(baseAddress);
//     var response = await client.GetAsync(requestUri);
//     response.EnsureSuccessStatusCode();

//     return await response.Content.ReadAsStringAsync();
//   }
// }

//     public record Root(
//         [property: JsonPropertyName("name")] string name,
//         [property: JsonPropertyName("rotation_period")] string rotation_period,
//         [property: JsonPropertyName("orbital_period")] string orbital_period,
//         [property: JsonPropertyName("diameter")] string diameter,
//         [property: JsonPropertyName("climate")] string climate,
//         [property: JsonPropertyName("gravity")] string gravity,
//         [property: JsonPropertyName("terrain")] string terrain,
//         [property: JsonPropertyName("surface_water")] string surface_water,
//         [property: JsonPropertyName("population")] string population,
//         [property: JsonPropertyName("residents")] IReadOnlyList<string> residents,
//         [property: JsonPropertyName("films")] IReadOnlyList<string> films,
//         [property: JsonPropertyName("created")] DateTime created,
//         [property: JsonPropertyName("edited")] DateTime edited,
//         [property: JsonPropertyName("url")] string url
//     );
using System.Text.Json.Serialization;
using System.Text.Json;

var baseAddress = "https://swapi.info/api/";
var uriAddress = "planets";
IClientApi clientApi = new ClientApi();
var json = await clientApi.Read(baseAddress, uriAddress);
var root = JsonSerializer.Deserialize<List<Root>>(json);

foreach (var plant in root)
{
  System.Console.WriteLine($"Planet {plant.name}, population size {plant.population}");
}

Console.ReadKey();

public interface IClientApi
{
  Task<string> Read(string baseAddress, string uriAddress);
}

public class ClientApi : IClientApi
{
  public async Task<string> Read(string baseAddress, string uriAddress)
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri(baseAddress);
    var response = await client.GetAsync(uriAddress);
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
var client = new HttpClient();
client.BaseAddress = new Uri("https://swapi.info/api/");
var response = await client.GetAsync("planets");
response.EnsureSuccessStatusCode();

var json = response.Content.ReadAsStringAsync();

Console.ReadKey();
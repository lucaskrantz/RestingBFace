using RestingBFace;
using RestSharp;
using System.Text.Json;
using System.IO;

string key = "b8e446694301440a9ddc235afc5f3420";

RestClient client = new RestClient("https://api.spoonacular.com/recipes/complexSearch");
RestRequest request = new RestRequest("?query=pasta");
request.AddParameter("apiKey", key);
RestResponse response = client.GetAsync(request).Result;
Console.WriteLine(response.Content);
File.WriteAllText("recipe.json", response.Content);

Console.ReadLine();

// Spoon s = JsonSerializer.Deserialize<Spoon>(response.Content);

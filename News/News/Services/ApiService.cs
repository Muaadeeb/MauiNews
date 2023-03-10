namespace News.Services;

public class ApiService
{
    private const string url = "https://gnews.io/api/v4/top-headlines?category=general&apikey=be1323e95fb4fa7316d1b7ecc96014f0&lang=en&topic=sports";

    public async Task<Root> GetNews()
    {
        var _client = new HttpClient();
        var response = await _client.GetAsync(url);
        return await ProcessResponseAsync(response);
    }

    public async Task<Root> ProcessResponseAsync(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode && response.StatusCode == HttpStatusCode.NoContent)
        {
            throw new Exception("No Data today");
        }

        var responseContent = await response.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return JsonSerializer.Deserialize<Root>(responseContent, options) ?? new Root();
    }
}
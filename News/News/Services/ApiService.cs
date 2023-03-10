using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using News.Models;
using SystemConfiguration;

namespace News.Services
{
    public class ApiService
    {
        private const string url = "https://gnews.io/api/v4/top-headlines?category=general&apikey=be1323e95fb4fa7316d1b7ecc96014f0&lang=en&topic=sports";

        public async Task<Root> GetNews()
        {
            //try
            //{
            //    HttpResponseMessage response = await _httpClient.GetAsync($"api/Structure/{modelId}/{parentId}");
            //    List<string> keyValues = new List<string> { modelId, parentId };
            //    return await ProcessResponseAsync(response, keyValues);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.ToString());
            //}


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
}

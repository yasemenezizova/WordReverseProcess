using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class ServiceProcess
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> MainTask(string word)
        {
            string url = "https://localhost:44345/home/all";
            string baseUrl = string.Concat(url, $"/{word}");
            string responseBody = string.Empty;
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Error has occured!");
            }
            return responseBody;
        }
    }
}

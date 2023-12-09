using System.Net.Http.Headers;

namespace Dad_Joke_generator.Models
{
    public class DadJokeFetcher
    {
        public static async Task<DadJoke?> CmonDad()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "My Library (https://github.com/kemmojr/Dad-Joke-generator)");
            try
            {

                HttpResponseMessage response = await client.GetAsync("https://icanhazdadjoke.com/");

                if (response.IsSuccessStatusCode)
                {
                    var dadJokeData = await response.Content.ReadFromJsonAsync<DadJoke>();

                    return dadJokeData;
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return null;
        }
    }

    public class DadJoke
    {
        public string? id { get; set; }
        public string? joke { get; set; }
        public int? status { get; set; }
        public DadJoke() { }
    }
}

using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace ConsoleAppAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                var newPost = new Posts()
                {
                    Title = "Test Post",
                    Body = "Hello World",
                    UserId = 44
                };
                var newPostJson = JsonConvert.SerializeObject(newPost);
                Console.WriteLine(newPostJson);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint,payload).Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);

                // GET Items in JSON
                //var result = client.GetAsync(endpoint).Result;
                //var json = result.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(json);
            }
        }
    }
}
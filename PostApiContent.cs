using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace ConsoleAppAPI
{
    public class PostApiContent
    {
        public string PostApiContentPosts(string endpoint, string title, string body, int UserId)
        {
            using(var client = new HttpClient())
            {
                var newPost = new
                    {
                        Title = title,
                        Body = body,
                        UserId = UserId
                    };
                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint + "posts",payload).Result.Content.ReadAsStringAsync().Result;
                return result;
            }
        }
    }
}
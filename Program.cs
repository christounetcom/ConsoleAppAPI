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
            string url = "https://jsonplaceholder.typicode.com/";
            var getPosts = new GetApiResponse("posts", url);
            var getTodos = new GetApiResponse("todoss", url);
            var resultJSON = getPosts.GetAPIEndpointJson();
            Console.WriteLine(resultJSON);
            Posts myPosts = JsonConvert.DeserializeObject<Posts>(resultJSON);

            foreach (var post in myPosts)
            {
                Console.WriteLine($"{post.id}");
            }
        
            //Console.WriteLine(getTodos.GetAPIEndpoint());

            var postMe = new PostApiContent();
            var result = postMe.PostApiContentPosts(url,"Test Post Here", "Hello to my world", 44);
        }
    }
}

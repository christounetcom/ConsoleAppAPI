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
            //Console.WriteLine(getPosts.GetAPIEndpoint());
            //Console.WriteLine(getTodos.GetAPIEndpoint());

            var postMe = new PostApiContent();
            var result = postMe.PostApiContentPosts(url,"Test Post Here", "Hello to my world", 44);
            Console.WriteLine(result);
        }
    }
}
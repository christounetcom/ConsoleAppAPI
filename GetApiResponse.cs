namespace ConsoleAppAPI
{
    public class GetApiResponse
    {
        public string endpoint;
        public string url;
        public GetApiResponse(string endpointRoute, string endPointURI)
        {
            endpoint = endpointRoute;
            url = endPointURI;
        }
        public string GetAPIEndpoint()
        {
            using(var client = new HttpClient())
            {
                var endpointURI = new Uri(url);
                var result = client.GetAsync(url + endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                return json;
            }
        }
    }
}
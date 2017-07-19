using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorld.Client
{
    public class HelloWorldManager:IHelloWorldManager
    {
        private HttpClient client { get; set; }
        private string apiUrl { get; set; }
        public HelloWorldManager()
        {
            client = new HttpClient();
            apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
        }
        public async Task<string> GetHelloWorldAsync()
        {
            string responseValue="";
            HttpResponseMessage response = await client.GetAsync(apiUrl+ "/helloworld");
            if (response.IsSuccessStatusCode)
            {
                responseValue = await response.Content.ReadAsStringAsync();
            }
            return responseValue;
        }
    }
}

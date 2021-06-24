using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            dynamic response = await Program.makeRequest("https://data-asg.goldprice.org/dbXRates/USD");
            Console.WriteLine(response);
            Console.ReadLine();
        }

        public static async Task<dynamic> makeRequest(string url)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync(url);
            dynamic json = JsonConvert.DeserializeObject(result);
            return json;

        }

    }
}

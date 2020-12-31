using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace currency_converter
{
    class Program
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string exchangeEndpoint = "https://api.exchangeratesapi.io/latest?base=USD";

            try
            {
                string responseBody = await client.GetStringAsync(exchangeEndpoint);
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            




        }
    }
}

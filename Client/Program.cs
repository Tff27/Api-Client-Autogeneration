namespace Client
{
    using SDK;
    using System;
    using System.Net.Http;

    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Nswag Generated Client");
            Console.ReadLine();

            // Created object of class ValuesClient  

            var httpClient = new HttpClient();
            var testClient = new WeatherServiceClientSDK("http://localhost:49183", httpClient);

            // Call GetAsync Values API  
            var getresult = await testClient.WeatherForecastAsync();

            // Call GetAllAsync Values API  

            foreach (var item in getresult)
            {
                Console.WriteLine($"Weather {item.Summary} is {item.TemperatureC}º/{item.TemperatureF}F on {item.Date}");
            }

            Console.ReadLine();
        }
    }
}

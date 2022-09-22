using SDK;
using System;
using System.Net.Http;

Console.WriteLine("Welcome to Nswag Generated Client");
Console.WriteLine("Press any key to fetch data");
Console.ReadLine();

// Created a new http client

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("ApiKey", "ApiKey123");

var testClient = new WeatherServiceClientSDK("http://localhost:49183", httpClient);

// Call a generated method
var getresult = await testClient.WeatherForecastAllAsync();
  
//Writes the response in the console
foreach (var item in getresult)
{
    Console.WriteLine($"Weather {item.Summary} is {item.TemperatureC}º/{item.TemperatureF}F on {item.Date}");
}

Console.WriteLine("Creating a new WeatherForecast");

// Create a new Weather Forecast
var newWeatherForecast = await testClient.WeatherForecastPOSTAsync(new WeatherForecastCreate
{
    Id = Guid.NewGuid(),
    Date = DateTime.UtcNow,
    Summary = "My new WeatherForecast",
    TemperatureC = 30
});

Console.WriteLine($"Weather {newWeatherForecast.Summary} is {newWeatherForecast.TemperatureC}º/{newWeatherForecast.TemperatureF}F on {newWeatherForecast.Date}");

Console.WriteLine("Press any key to exit");
Console.ReadLine();
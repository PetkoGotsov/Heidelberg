using Microsoft.AspNetCore.Mvc;
using OpenWeatherAPI;

namespace Heidelberg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly string _apiKey;

        public WeatherForecastController()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _apiKey = config.GetValue<string>("OpenWeatherMap:ApiKey");
        }

        [HttpGet(Name = "GetWeatherForecast")]  
        public async Task<QueryResponse> Get(string city)
        {
            var openWeatherAPI = new OpenWeatherApiClient(_apiKey);
            // Use async version wherever possible
            var query = await openWeatherAPI.QueryAsync(city);
            return query;
        }
    }
}
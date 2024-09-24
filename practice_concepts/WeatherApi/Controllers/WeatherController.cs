using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;


namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class WeatherController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult TestEndpoint()
        {
            return Ok("Successfullll");
        }
        private readonly HttpClient _httpClient;

        public WeatherController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeather(string city)
        {
            Console.WriteLine($"Fetching weather data for: {city}");
            string apiKey = "d1854ffe0ba2038f212feafd0aebd90c";
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try 
            {
                Console.WriteLine("htting here");
                var response = await _httpClient.GetStringAsync(apiUrl);
                Console.WriteLine(response);
                return Ok(response);
            }

            catch (HttpRequestException e)
            {
                return BadRequest($"Error fetching api : {e.Message}");
            }
        }

    }
}
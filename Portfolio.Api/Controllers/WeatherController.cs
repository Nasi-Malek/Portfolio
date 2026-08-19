using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class WeatherController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public WeatherController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet("{city}")]
    public async Task<IActionResult> GetWeather(string city)
    {
        var url = $"https://api.open-meteo.com/v1/forecast?latitude=59.33&longitude=18.07&current_weather=true";

        var response = await _httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode) return StatusCode((int)response.StatusCode);

        var json = await response.Content.ReadAsStringAsync();
        return Content(json, "application/json");
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;

public class WeatherModel : PageModel
{
    private readonly HttpClient _httpClient;
    public string WeatherJson { get; set; }

    public WeatherModel(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task OnGetAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:5001/api/weather/stockholm");
        if (response.IsSuccessStatusCode)
        {
            WeatherJson = await response.Content.ReadAsStringAsync();
        }
    }
}

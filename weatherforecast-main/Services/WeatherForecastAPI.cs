using System;
using WeatherAPI;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
  public class WeatherForecastAPI : IWeatherForcastAPI
  {
    public WeatherForecastAPI()
    {
    }

    public async Task<WeatherObject> GetCityWeather(string CityName)
    { 

      var baseUrl = "https://api.openweathermap.org/data/2.5/weather?q=";
      var ApiKey = "da60d21da98419e708a2cbb21141e684";

      using (var client = new HttpClient())
      {
    
        var response = await client.GetAsync($"{baseUrl}{CityName}&appid={ApiKey}");

        if (!response.IsSuccessStatusCode)
        {
          var errorResponse = await response.Content.ReadAsStringAsync();
          return null;
        }

        var responseJson = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<WeatherObject>(responseJson);

     }
    }
  }
}

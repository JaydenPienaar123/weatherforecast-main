using System.Collections.Generic;
using WeatherAPI;
using System.Threading.Tasks;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
  public interface IWeatherForcastAPI
  {
    Task<WeatherObject> GetCityWeather(string CityName);
  }
}

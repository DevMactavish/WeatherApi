using System.Threading.Tasks;
using Weather.Data;

namespace Weather.Service
{
    public interface IWeatherForecastService
    {
        Task<WeatherResponse> Get(string cityName, int day);
    }
}
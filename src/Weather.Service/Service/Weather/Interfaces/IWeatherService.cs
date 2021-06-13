using System.Threading.Tasks;
using Weather.Data;

namespace Weather.Service
{
    public interface IWeatherCurrentService
    {
        Task<WeatherResponse> Get(string cityName);
    }
}
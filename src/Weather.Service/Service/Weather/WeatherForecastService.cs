using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;
using Weather.Data;

namespace Weather.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IFlurlClient _flurlClient;
        private readonly GeneralSettings _generalSettings;
        public WeatherForecastService(IFlurlClientFactory factory, IOptions<GeneralSettings> generalSettings)
        {
            _generalSettings = generalSettings.Value;
            _flurlClient = factory.Get(_generalSettings.WeatherApiUrl + _generalSettings.ForecastUrl);
        }
        public async Task<WeatherResponse> Get(string cityName, int day)
        {
            var query = new { key = _generalSettings.ApiKey, q = cityName, days = day };
            return await _flurlClient
                .Request()
                .SetQueryParams(query)
                .GetAsync()
                .ReceiveJson<WeatherResponse>();
        }
    }
}
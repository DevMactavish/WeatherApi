using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;
using Weather.Data;


namespace Weather.Service
{
    public class WeatheCurrentService : IWeatherCurrentService
    {
        private readonly IFlurlClient _flurlClient;
        private readonly GeneralSettings _generalSettings;
        public WeatheCurrentService(IFlurlClientFactory factory, IOptions<GeneralSettings> generalSettings)
        {
            _generalSettings = generalSettings.Value;
            _flurlClient = factory.Get(_generalSettings.WeatherApiUrl + _generalSettings.CurrentUrl);
        }
        public async Task<WeatherResponse> Get(string cityName)
        {
            var query = new { key = _generalSettings.ApiKey, q = cityName };
            return await _flurlClient
                .Request()
                .SetQueryParams(query)
                .GetAsync()
                .ReceiveJson<WeatherResponse>();
        }
    }
}
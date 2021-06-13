namespace Weather.Data
{
    public class WeatherResponse
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
        public Forecast Forecast { get; set; }
    }
}
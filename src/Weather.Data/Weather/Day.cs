namespace Weather.Data
{
    public class Day
    {
        public double MaxtempC { get; set; }
        public double MaxtempF { get; set; }
        public double MintempC { get; set; }
        public double MintempF { get; set; }
        public double AvgtempC { get; set; }
        public double AvgtempF { get; set; }
        public double MaxwindMph { get; set; }
        public double MaxwindKph { get; set; }
        public double TotalprecipMm { get; set; }
        public double TotalprecipIn { get; set; }
        public double AvgvisKm { get; set; }
        public double AvgvisMiles { get; set; }
        public double Avghumidity { get; set; }
        public int DailyWillItRain { get; set; }
        public string DailyChanceOfRain { get; set; }
        public int DailyWillItSnow { get; set; }
        public string DailyChanceOfSnow { get; set; }
        public Condition Condition { get; set; }
        public double Uv { get; set; }
    }
}
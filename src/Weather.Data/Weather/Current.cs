namespace Weather.Data
{
    public class Current
    {
        public int LastUpdatedEpoch { get; set; }
        public string LastUpdated { get; set; }
        public double TempC { get; set; }
        public double TempF { get; set; }
        public int IsDay { get; set; }
        public Condition Condition { get; set; }
        public double WindMph { get; set; }
        public double WindKph { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public double PressureMb { get; set; }
        public double PressureIn { get; set; }
        public double PrecipMm { get; set; }
        public double PrecipIn { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double FeelslikeC { get; set; }
        public double FeelslikeF { get; set; }
        public double VisKm { get; set; }
        public double VisMiles { get; set; }
        public double Uv { get; set; }
        public double GustMph { get; set; }
        public double GustKph { get; set; }
    }
}
using System.Collections.Generic;

namespace Weather.Data
{
    public class Forecastday
    {
        public string Date { get; set; }
        public int DateEpoch { get; set; }
        public Day Day { get; set; }
        public Astro Astro { get; set; }
        public List<Hour> Hour { get; set; }
    }
}
using System.Diagnostics.CodeAnalysis;

namespace WeatherApp.Models
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Weather
    {
        public string weather_state_name { get; set; }

        public string weather_state_abbr { get; set; }

        public string wind_direction_compass { get; set; }

        public string applicable_date { get; set; }

        public string min_temp { get; set; }

        public string max_temp { get; set; }
    }
}

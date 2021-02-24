using System;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel
    {
        public string State { get; set; }

        public string WindDirection { get; set; }

        public string WindAbbr { get; set; }

        public DateTime Day { get; set; }

        public double MinTemp { get; set; }

        public double MaxTemp { get; set; }

        public string Image { get; set; }
    }
}

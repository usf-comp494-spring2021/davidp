using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DPaul_Final.Models
{
    /// <summary>
    /// Data model for the weather forecast api
    /// </summary>
    public class WeatherForecast
    {
        public DateTime forecastDate { get; set; }
        public string location { get; set; }
        public double temperature { get; set; }
        public double feelsLike { get; set; }
        public string descriptor { get; set; }
        public string imagePath { get; set; }
        public double windSpeed { get; set; }
        public string windDirection { get; set; }
        public double pressure { get; set; }

    }
}

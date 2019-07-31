using System;

namespace Predictor.Models.Hourly.DataStructures
{
    public class WeatherDescription : Cities<string>
    {
        public DateTime DateTime { get; set; }
    }
}

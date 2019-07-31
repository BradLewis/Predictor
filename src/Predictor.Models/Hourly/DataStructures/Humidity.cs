using System;

namespace Predictor.Models.Hourly
{
    public class Humidity : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

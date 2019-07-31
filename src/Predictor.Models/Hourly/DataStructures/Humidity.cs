using System;

namespace Predictor.Models.Hourly.DataStructures
{
    public class Humidity : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

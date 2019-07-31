using System;

namespace Predictor.Models.Hourly.DataStructures
{
    public class WindDirection : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

using System;

namespace Predictor.Models.Hourly.DataStructures
{
    public class WindSpeed : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

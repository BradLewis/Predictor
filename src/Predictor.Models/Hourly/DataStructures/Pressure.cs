using System;

namespace Predictor.Models.Hourly.DataStructures
{
    public class Pressure : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

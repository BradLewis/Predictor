using System;

namespace Predictor.Models.Hourly.DataStructures
{
    public class Temperature : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

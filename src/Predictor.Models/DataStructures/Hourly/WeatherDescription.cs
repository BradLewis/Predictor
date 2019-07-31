using System;
using Microsoft.ML.Data;

namespace Predictor.Models.Hourly.DataStructures
{
    public class WeatherDescription : Cities<string>
    {
        [LoadColumn(0)]
        public DateTime DateTime { get; set; }
    }
}

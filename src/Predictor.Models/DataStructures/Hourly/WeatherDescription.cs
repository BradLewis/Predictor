using System;
using Microsoft.ML.Data;

namespace Predictor.Models.DataStructures.Hourly
{
    public class WeatherDescription : Cities<string>
    {
        [LoadColumn(0)]
        public DateTime DateTime { get; set; }
    }
}

using System;
using Microsoft.ML.Data;

namespace Predictor.Models.Hourly.DataStructures
{
    public class Pressure : Cities<double>
    {
        [LoadColumn(0)]
        public DateTime DateTime { get; set; }
    }
}

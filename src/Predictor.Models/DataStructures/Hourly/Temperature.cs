using System;
using Microsoft.ML.Data;

namespace Predictor.Models.DataStructures.Hourly
{
    public class Temperature : Cities<float>
    {
        [LoadColumn(0)]
        public DateTime DateTime { get; set; }
    }
}

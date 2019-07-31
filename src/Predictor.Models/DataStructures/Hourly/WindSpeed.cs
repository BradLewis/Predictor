﻿using System;
using Microsoft.ML.Data;

namespace Predictor.Models.DataStructures.Hourly
{
    public class WindSpeed : Cities<double>
    {
        [LoadColumn(0)]
        public DateTime DateTime { get; set; }
    }
}

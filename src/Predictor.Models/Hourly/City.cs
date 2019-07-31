﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Predictor.Models.Hourly
{
    public class City
    {
        public double Humdity { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }
        public string WeatherDescription { get; set; }
        public double WindDirection { get; set; }
        public double WindSpeed { get; set; }
    }
}

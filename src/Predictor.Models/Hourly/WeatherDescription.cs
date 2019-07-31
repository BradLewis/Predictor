using System;
using System.Collections.Generic;
using System.Text;

namespace Predictor.Models.Hourly
{
    public class WeatherDescription : Cities<string>
    {
        public DateTime DateTime { get; set; }
    }
}

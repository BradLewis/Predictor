﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Predictor.Models.Hourly
{
    public class WindSpeed : Cities<double>
    {
        public DateTime DateTime { get; set; }
    }
}

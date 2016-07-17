﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.CartesianChart.Linq
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Population { get; set; }
        public double Area { get; set; }
        public string Country { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CityForecast
    {
        public string City { get; set; }
        public decimal MaxTemperature { get; set; }
        public String Description { get; set; }
    }
}
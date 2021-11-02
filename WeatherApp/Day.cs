using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Day
    {
        public string date, currentTime, condition, location, windSpeed, windDirection, precipitation, visibility;
        public double currentTemp, tempHigh, tempLow;
        public Day()
        {
            date =  currentTime = condition = location = windSpeed = windDirection = precipitation = visibility = "";
        }
    }
}

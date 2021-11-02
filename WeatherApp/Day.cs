using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, windSpeed, windDirection, precipitation, visibility;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = "";
        }
    }
}

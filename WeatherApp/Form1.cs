/*November 2021
 * Justin Andrews
 * An app displaying current and future weather
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()  //Getting weather information for the forecast
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day newDay = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.foreCond = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                newDay.tempLow = Convert.ToDouble(reader.GetAttribute("min"));
                newDay.tempHigh = Convert.ToDouble(reader.GetAttribute("max"));

                //TODO: if day object not null add to the days list
                days.Add(newDay);
            }
        }

        private void ExtractCurrent()   //Getting weather information for the current weather
        {
            // current info is not included in forecast file so we need to use this file to get it


            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value"));

            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("number");
        }
    }
}

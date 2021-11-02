using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            #region Number and day displays
            day1Label.Text = DateTime.Now.AddDays(1).ToString("dd, MMM, yyyy");
            day2Label.Text = DateTime.Now.AddDays(2).ToString("dd, MMM, yyyy");
            day3Label.Text = DateTime.Now.AddDays(3).ToString("dd, MMM, yyyy");
            day4Label.Text = DateTime.Now.AddDays(4).ToString("dd, MMM, yyyy");
            day5Label.Text = DateTime.Now.AddDays(5).ToString("dd, MMM, yyyy");

            max1Output.Text = Form1.days[1].tempHigh.ToString("0") + "°C";
            max2Output.Text = Form1.days[2].tempHigh.ToString("0") + "°C";
            max3Output.Text = Form1.days[3].tempHigh.ToString("0") + "°C";
            max4Output.Text = Form1.days[4].tempHigh.ToString("0") + "°C";
            max5Output.Text = Form1.days[5].tempHigh.ToString("0") + "°C";

            min1Output.Text = Form1.days[1].tempLow.ToString("0") + "°C";
            min2Output.Text = Form1.days[2].tempLow.ToString("0") + "°C";
            min3Output.Text = Form1.days[3].tempLow.ToString("0") + "°C";
            min4Output.Text = Form1.days[4].tempLow.ToString("0") + "°C";
            min5Output.Text = Form1.days[5].tempLow.ToString("0") + "°C";
            #endregion  //Display the dates and the min max temperatures

            iconSelect();
        }

        private void todayLabel_Click(object sender, EventArgs e)   //Go to today's weather screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void iconSelect()   //Choose icons for the next days
        {
            int climate = Convert.ToInt32(Form1.days[1].foreCond);

            if (climate > 199 && climate < 300)
            {
                icon1Box.Image = Properties.Resources.thunderIcon;
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
            }
            else if (climate > 300 && climate < 600)
            {
                icon1Box.Image = Properties.Resources.rainIcon;
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
            }
            else if (climate > 600 && climate < 700)
            {
                icon1Box.Image = Properties.Resources.snowIcon;
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
            }
            else if (climate == 800)
            {
                icon1Box.Image = Properties.Resources.sunIcon;
                this.BackgroundImage = Properties.Resources.sunnyBackImage;
            }
            else if (climate > 800)
            {
                icon1Box.Image = Properties.Resources.cloudIcon;
                this.BackgroundImage = Properties.Resources.sunnyBackImage;
            }

            climate = Convert.ToInt32(Form1.days[2].foreCond);

            if (climate > 199 && climate < 300)
            {
                icon2Box.Image = Properties.Resources.thunderIcon;
            }
            else if (climate > 300 && climate < 600)
            {
                icon2Box.Image = Properties.Resources.rainIcon;
            }
            else if (climate > 600 && climate < 700)
            {
                icon2Box.Image = Properties.Resources.snowIcon;
            }
            else if (climate == 800)
            {
                icon2Box.Image = Properties.Resources.sunIcon;
            }
            else if (climate > 800)
            {
                icon2Box.Image = Properties.Resources.cloudIcon;
            }

            climate = Convert.ToInt32(Form1.days[3].foreCond);

            if (climate > 199 && climate < 300)
            {
                icon3Box.Image = Properties.Resources.thunderIcon;
            }
            else if (climate > 300 && climate < 600)
            {
                icon3Box.Image = Properties.Resources.rainIcon;
            }
            else if (climate > 600 && climate < 700)
            {
                icon3Box.Image = Properties.Resources.snowIcon;
            }
            else if (climate == 800)
            {
                icon3Box.Image = Properties.Resources.sunIcon;
            }
            else if (climate > 800)
            {
                icon3Box.Image = Properties.Resources.cloudIcon;
            }

            climate = Convert.ToInt32(Form1.days[4].foreCond);

            if (climate > 199 && climate < 300)
            {
                icon4Box.Image = Properties.Resources.thunderIcon;
            }
            else if (climate > 300 && climate < 600)
            {
                icon4Box.Image = Properties.Resources.rainIcon;
            }
            else if (climate > 600 && climate < 700)
            {
                icon4Box.Image = Properties.Resources.snowIcon;
            }
            else if (climate == 800)
            {
                icon4Box.Image = Properties.Resources.sunIcon;
            }
            else if (climate > 800)
            {
                icon4Box.Image = Properties.Resources.cloudIcon;
            }

            climate = Convert.ToInt32(Form1.days[5].foreCond);

            if (climate > 199 && climate < 300)
            {
                icon5Box.Image = Properties.Resources.thunderIcon;
            }
            else if (climate > 300 && climate < 600)
            {
                icon5Box.Image = Properties.Resources.rainIcon;
            }
            else if (climate > 600 && climate < 700)
            {
                icon5Box.Image = Properties.Resources.snowIcon;
            }
            else if (climate == 800)
            {
                icon5Box.Image = Properties.Resources.sunIcon;
            }
            else if (climate > 800)
            {
                icon5Box.Image = Properties.Resources.cloudIcon;
            }
        }
    }
}

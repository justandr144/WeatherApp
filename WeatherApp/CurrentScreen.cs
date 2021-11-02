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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {

            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp.ToString("0") + "°C";
            minOutput.Text = Form1.days[0].tempLow.ToString("0") + "°C";
            maxOutput.Text = Form1.days[0].tempHigh.ToString("0") + "°C";

            int climate = Convert.ToInt32(Form1.days[0].condition);

            if (climate > 199 && climate < 300)     //Choose icon, background, and weather title
            {
                conditionLabel.Text = "Thunderstorm";
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
                iconBox.Image = Properties.Resources.thunderIcon;
            }
            else if (climate > 300 && climate < 600)
            {
                conditionLabel.Text = "Rain";
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
                iconBox.Image = Properties.Resources.rainIcon;
            }
            else if (climate > 600 && climate < 700)
            {
                conditionLabel.Text = "Snow";
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
                iconBox.Image = Properties.Resources.snowIcon;
            }
            else if (climate == 800)
            {
                conditionLabel.Text = "Clear";
                this.BackgroundImage = Properties.Resources.sunnyBackImage;
                iconBox.Image = Properties.Resources.sunIcon;
            }
            else if (climate > 800)
            {
                conditionLabel.Text = "Cloudy";
                this.BackgroundImage = Properties.Resources.sunnyBackImage;
                iconBox.Image = Properties.Resources.cloudIcon;
            }

            dateOutput.Text = DateTime.Now.ToString("dd, MMM, yyyy");
        }

        private void nextLabel_Click(object sender, EventArgs e)    //go to forecast screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}

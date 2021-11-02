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

            climate = 200;

            if (climate > 199 && climate < 300)
            {
                conditionLabel.Text = "Thunderstorm";
                this.BackgroundImage = Properties.Resources.cloudyBackImage;
                iconBox.Image = Properties.Resources.thunderIcon;
            }

            dateOutput.Text = DateTime.Now.ToString("dd, MMM, yyyy");
        }

        private void nextLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}

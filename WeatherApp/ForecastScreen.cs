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


            #endregion
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}

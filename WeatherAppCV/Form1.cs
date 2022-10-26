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
using Newtonsoft.Json;

namespace WeatherAppCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "754e8f463353bfe60aad8621afd345b5";

        private void CityBox_Click(object sender, EventArgs e)
        {
            CityBox.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityBox.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInformation.root Info = JsonConvert.DeserializeObject<WeatherInformation.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

                WeatherLabel.Text = Info.weather[0].main;
                DescriptionLabel.Text = Info.weather[0].description.ToUpper();

                TemperatureLabel.Text = kelvinToCelcius(Info.main.temp).ToString() + " °C";
                MinTempLabel.Text = kelvinToCelcius(Info.main.temp_min).ToString() + " °C";
                MaxTempLabel.Text = kelvinToCelcius(Info.main.temp_max).ToString() + " °C";
                FeelsLikeLabel.Text = kelvinToCelcius(Info.main.feels_like).ToString() + " °C";
                HumidityLabel.Text = Info.main.humidity.ToString() + "%";

            }
        }

        double kelvinToCelcius(double x)
        {
            double temperature = x - 273.15;
            int celcius = (int)temperature;
            return celcius;
        }
    }
}

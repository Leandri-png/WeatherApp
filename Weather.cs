using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTask1
{
    public class Weather
    {
        //Reference: (Doyle, 2016)
        //variables to store date
        private string province, city;
        private int maxTemp, minTemp, precipitation, humidity, windSpeed;
        private DateTime date;

        //get and set methods for vraiables
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public int MaxTemp
        {
            get { return maxTemp; }
            set { maxTemp = value; }
        }

        public int MinTemp
        {
            get { return minTemp; }
            set { minTemp = value; }
        }

        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public int Precipitation
        {
            get { return precipitation; }
            set { precipitation = value; }
        }
        public int WindSpeed
        {
            get { return windSpeed; }
            set { windSpeed = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherMap : WeatherData , IWeatherDataService
    {
        private static WeatherMap weatherMap;
        private WeatherMap() : base() { }

        public static WeatherMap Instance()
        {
            if (weatherMap==null)
            {
                weatherMap = new WeatherMap();
            }
            return weatherMap;
        }


    }
}

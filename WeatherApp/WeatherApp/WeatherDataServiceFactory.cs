using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherDataServiceFactory
    {
        public static String OPEN_WEATHER_MAP = "OPEN_WEATHER_MAP";
        public static String WORLD_WEATHER_ONLINE = "WORLD_WEATHER_ONLINE";

        public static WeatherData getWeatherDataService(String data){
            WeatherData weatherData = new WeatherData();
            if (data.Equals(OPEN_WEATHER_MAP))
            {
                return WeatherMap.Instance();
            }
            else if (data.Equals(WORLD_WEATHER_ONLINE))
            {
                return WeatherWorld.Instance();
            }
            return weatherData;
        }
        
    }
}

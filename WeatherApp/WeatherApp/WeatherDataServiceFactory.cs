using System;

namespace WeatherApp{
    /// <summary> 
    /// Factory Method of Weather Data Services
    /// </summary>
    class WeatherDataServiceFactory{
        public static String OPEN_WEATHER_MAP = "OPEN_WEATHER_MAP" , WORLD_WEATHER_ONLINE = "WORLD_WEATHER_ONLINE";

        public static WeatherData getWeatherDataService(String info){
            if (info.Equals(OPEN_WEATHER_MAP)) return WeatherMap.Instance();     
            else if (info.Equals(WORLD_WEATHER_ONLINE)) return WeatherWorld.Instance();
            return new WeatherData();
        }
    }
}
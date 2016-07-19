using System;

namespace WeatherApp{
    class Program{
        static void Main(string[] args){
            /// <summary> 
            /// Get Weather Data for: "location"
            /// </summary>
            IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(
                WeatherDataServiceFactory.WORLD_WEATHER_ONLINE);
            WeatherData weatherData = service.getWeatherData(new Location("London"));
            weatherData.Start();
            Console.ReadKey();
        }
    }
}
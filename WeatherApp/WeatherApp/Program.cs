using System;

namespace WeatherApp{
    class Program{
        static void Main(string[] args){
            /// <summary> 
            /// Get Weather Data for: "location"
            /// </summary>
            IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(
                WeatherDataServiceFactory.OPEN_WEATHER_MAP);
            WeatherData weatherData = service.getWeatherData(new Location("Israel"));
            weatherData.Start();
            Console.ReadKey();
        }
    }
}
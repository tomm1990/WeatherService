using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp{
    class Program{
        static void Main(string[] args){
            IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(
                WeatherDataServiceFactory.OPEN_WEATHER_MAP);
            WeatherData wd = service.getWeatherData(new Location("Paris, France"));
            
            wd.Start();
            Console.ReadKey();
        }
    }
}

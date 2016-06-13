using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    //should be implemented as singleton
    public class WeatherData : IWeatherDataService
    {
         

        public WeatherData GetWeatherData(Location location)
        {
            throw new NotImplementedException();
        }
    }
}

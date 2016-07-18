using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp{
    /// <summary> 
    /// App Interface
    /// </summary>
    public interface IWeatherDataService{
        WeatherData getWeatherData(Location location);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp{
    public class WeatherData : IWeatherDataService{

        private Location location;

        public Location Location{
            get { return location; }
            set {  location = value; }
        }
        
        public WeatherData() { this.location = new Location(); }
        
        virtual public WeatherData getWeatherData(Location location){
            throw new NotImplementedException("\ngetWeatherData() was not implemented\n");
        }

        public void Start(){
            Console.WriteLine(
               "--- Welcome ---\n\n" +
               "The Weather of " + location.Country + ":\n" +
               "Tempature is  : " + location.Temperature + " Celsius\n" +
               "Sunrise is : " + location.Sunrise + "\n" +
               "Sunset is : " + location.Sunset + "\n" +
               "Clouds condition is : " + location.Cloud + "\n" +
               "Wind Speed is : " + location.Wind + "\n" +
               "Humidity is : " + location.Humidity + "%\n" +
               "\n\n-- Last Update : " + location.Lastupdate+"\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherData : IWeatherDataService{

        private Location location;

        public Location Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }


        public WeatherData() {
            this.location = new Location();
        }


        virtual public WeatherData getWeatherData(Location location)
        {
            throw new NotImplementedException();
        }



        public void Start()
        {
          
                Console.WriteLine(
                   "The weather of " + Location.Country + " is:\n" +
                   "SunRise is: " + Location.Sunrise + "\n" +
                   "SunSet is: " + Location.Sunset + "\n" +
                   "Temperature is: " + Location.Temperature + " Celsius\n" +
                   "Humidity is: " +Location.Humidity + "\n" +
                   "Wind Speed is: " + Location.Wind + " \n" +
                   "Clouds is: " + Location.Cloud + "\n" +
                   "Last update for this weather is: " + Location.Lastupdate);
            
        }
    }
}

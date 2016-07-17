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

        private Location location;

        public WeatherData() {
            this.Location = new Location();
        }

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

        virtual public WeatherData getWeatherData(Location location)
        {
            throw new NotImplementedException();
        }



        public void Start()
        {
            Console.WriteLine("test");
        }
    }
}

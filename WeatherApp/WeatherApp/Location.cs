using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Location
    {
        private String country;

        public Location() { }

        public Location(String location)
        {
            country = location;
        }
        public String Country
        {
            get
            {
                return country;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Wrong value for country");
                }
                else
                {
                    country = value;
                }
            }
        }


    }
}

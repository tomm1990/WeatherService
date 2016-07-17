using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp{
    public class Location{
        private String country;
        private String sunrise;
        private String sunset;
        private String cloud;
        private String humidity;
        private String lastupdate;
        private String wind;
        private String temperature;

        public String Country{
            get { return country; }
            set { country = value; }
        }
        

        public String Sunrise
        {
            get { return sunrise; }
            set { sunrise = value; }
        }
        

        public String Sunset
        {
            get { return sunset; }
            set { sunset = value; }
        }
      

        public String Cloud
        {
            get { return cloud; }
            set { cloud = value; }
        }
    

        public String Wind
        {
            get { return wind; }
            set { wind = value; }
        }
        

        public String Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public String Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        

        public String Lastupdate
        {
            get { return lastupdate; }
            set { lastupdate = value; }
        }
       
           
        public Location() { }

        public Location(String location) {
            country = location;
        }    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WeatherApp{
    public class WeatherMap : WeatherData , IWeatherDataService{
        private const double Kalvin = 273.15;
        private String URLStringXML = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const String key = "046bf0944893aecfb599b36875c0a1d8";
        private static WeatherMap weatherMap;
        private WeatherMap() : base() { }

        public static WeatherMap Instance(){
            return weatherMap == null ? new WeatherMap() : weatherMap;
        }

        public override WeatherData getWeatherData(Location location){
            Location.Country = location.Country;
            XMLFunction(this, location);
            return this;
        }

        public void XMLFunction(WeatherMap wd, Location location){
            URLStringXML += location.Country + "&mode=xml&appid=" + key;
            WebClient client = new WebClient();
            XDocument xmlDoc;
            string xml;
            try { xml = client.DownloadString(URLStringXML);  }
            catch (WebException) { throw new WeatherDataServiceException("Wrong String of info"); }
            try{
                xmlDoc = XDocument.Parse(xml);
                wd.Location.Country = xmlDoc.Descendants("city").Attributes("name").First().Value;
                wd.Location.Sunrise = xmlDoc.Descendants("sun").Attributes("rise").First().Value;
                wd.Location.Sunset = xmlDoc.Descendants("sun").Attributes("set").First().Value;
                wd.Location.Cloud = xmlDoc.Descendants("clouds").Attributes("name").First().Value;
                wd.Location.Humidity = xmlDoc.Descendants("humidity").Attributes("value").First().Value;
                wd.Location.Wind = xmlDoc.Descendants("speed").Attributes("value").First().Value;
                wd.Location.Lastupdate = xmlDoc.Descendants("lastupdate").Attributes("value").First().Value;
                wd.Location.Temperature = Convert.ToString(double.Parse(xmlDoc.Descendants("temperature").Attributes("value").First().Value) - Kalvin);
            }
            catch (XmlException) { throw new WeatherDataServiceException("XmlException"); }
        }
    }
}
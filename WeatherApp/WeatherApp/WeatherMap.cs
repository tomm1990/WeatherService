using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WeatherApp
{
    // singleton WeatherMap object
    public class WeatherMap : WeatherData , IWeatherDataService
    {
        //private Location location;
        private static WeatherMap weatherMap;
        private WeatherMap() : base() { }

        public static WeatherMap Instance()
        {
            if (weatherMap==null)
            {
                weatherMap = new WeatherMap();
            }
            return weatherMap;
        }

        public override WeatherData getWeatherData(Location location)
        {
            WeatherMap wd = new WeatherMap();

            try
            {
                wd.Location.Country = location.Country;
                XMLFunction(wd, location);
            }
            catch (WeatherDataServiceException ex)
            {
                //Console.WriteLine(ex.Message);
            }
            return wd;
        }

        public void XMLFunction(WeatherMap wd, Location location)
        {
            //String URLString = "http://api.openweathermap.org/data/2.5/weather?q=" + location.Country + "&mode=xml";
            String URLString = "http://api.openweathermap.org/data/2.5/weather?q=" + location.Country + "&mode=xml&appid=" + "046bf0944893aecfb599b36875c0a1d8";
            String xml;
            using (WebClient client = new WebClient())
            {
                try
                {
                    xml = client.DownloadString(URLString);  // xml url to string
                }
                catch (WebException)
                {
                    throw new WeatherDataServiceException("There is not internet connection");
                }
            }
            try
            {
                XDocument ob = XDocument.Parse(xml);
                //A linq to xml that get all the values from the site
                var weather = from x in ob.Descendants("current")
                              select new
                              {
                                  City = x.Descendants("city").Attributes("name").First().Value,
                                  Sun = x.Descendants("sun").Attributes("rise").First().Value,
                                  Set = x.Descendants("sun").Attributes("set").First().Value,
                                  Tempat = x.Descendants("temperature").Attributes("value").First().Value,
                                  Cloud = x.Descendants("clouds").Attributes("name").First().Value,
                                  Humidity = x.Descendants("humidity").Attributes("value").First().Value,
                                  Speed = x.Descendants("speed").Attributes("value").First().Value,
                                  Direction = x.Descendants("direction").Attributes("code").First().Value,
                                  Update = x.Descendants("lastupdate").Attributes("value").First().Value,
                              };

                //Get all the values from the linq vairables and set 
                //them into the WeatherData service values.
                foreach (var data in weather)
                {
                    
                    wd.Location.Country = data.City;
                    wd.Location.Sunrise = data.Sun;
                    wd.Location.Sunset = data.Set;
                    wd.Location.Lastupdate = data.Update;
                    wd.Location.Temperature = data.Tempat;
                    wd.Location.Cloud = data.Cloud;
                    wd.Location.Humidity = data.Humidity;
                    wd.Location.Wind = data.Speed;
                }
            }
            catch (XmlException)
            {
                throw new WeatherDataServiceException("Wrong Country");
            }
            catch (WebException)
            {
                throw new WeatherDataServiceException("There is not internet connection");
            }
        }




    }
}

using Newtonsoft.Json.Linq;
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
    public class WeatherWorld : WeatherData, IWeatherDataService
    {
        private const String key = "7f41c073c67a4bdbac785947161707";
        private static WeatherWorld weatherWorld;
        private WeatherWorld() : base() { }
        public static WeatherWorld Instance()
        {
            
            if (weatherWorld == null)
            {
                weatherWorld = new WeatherWorld();
            }
            return weatherWorld;
        }

        public override WeatherData getWeatherData(Location location)
        {
            WeatherWorld wd = new WeatherWorld();

            try
            {
                wd.Location.Country = location.Country;
                JsonFunction(wd, location);
            }
            catch (WeatherDataServiceException ex)
            {

            }
            return wd;
        }

        public void JsonFunction(WeatherWorld wd, Location location)
        {
            String URLStringjson = "http://api.worldweatheronline.com/premium/v1/weather.ashx?key=" +
                       key + "&q=" + location.Country + "&num_of_days=1&tp=24&format=json";
            string json;
            using (WebClient client = new WebClient())
            {
                try
                {
                    json = @client.DownloadString(URLStringjson);
                }
                catch (WebException)
                {
                    throw new WeatherDataServiceException("There is not internet connection");
                }

            }
            try
            {
                JObject o = JObject.Parse(json);
                wd.Location.Country = (string)o["data"]["request"][0]["query"];
                wd.Location.Sunrise = (string)o["data"]["weather"][0]["astronomy"][0]["sunrise"];
                wd.Location.Sunset = (string)o["data"]["weather"][0]["astronomy"][0]["sunset"];
                wd.Location.Cloud = (string)o["data"]["weather"][0]["hourly"][0]["cloudcover"];
                wd.Location.Lastupdate = (string)o["data"]["weather"][0]["date"];
                wd.Location.Temperature = (string)o["data"]["current_condition"][0]["temp_C"];
                wd.Location.Humidity = (string)o["data"]["current_condition"][0]["humidity"];
                wd.Location.Wind = (string)o["data"]["current_condition"][0]["windspeedKmph"];
            }
            catch (Exception e) { };
        }


    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WeatherApp{
    /// <summary> 
    /// Get Json Object from "Weather World" 
    /// </summary>
    public class WeatherWorld : WeatherData, IWeatherDataService{
        private const String key = "7f41c073c67a4bdbac785947161707";
        private String URLStringjson = "http://api.worldweatheronline.com/premium/v1/weather.ashx?key=" + key;
        private static WeatherWorld weatherWorld;
        private WeatherWorld() : base() { }
        public static WeatherWorld Instance(){
            return weatherWorld == null ? new WeatherWorld() : weatherWorld;
        }

        public override WeatherData getWeatherData(Location location){
            Location.Country = location.Country;
            JsonFunction(this, location);
            return this;
        }
        /// <summary> 
        /// Json parser function from "Weather World" 
        /// </summary>
        public void JsonFunction(WeatherWorld wd, Location location){
            URLStringjson +=  "&q=" + location.Country + "&num_of_days=1&tp=24&format=json";
            WebClient client = new WebClient();
            string json;
            try{ json = @client.DownloadString(URLStringjson); }
            catch (WebException) { throw new WeatherDataServiceException("Wrong String of info"); }
            try{
                JObject jsonObject = JObject.Parse(json);
                Location.Country = (string)jsonObject["data"]["request"][0]["query"];
                Location.Sunrise = (string)jsonObject["data"]["weather"][0]["astronomy"][0]["sunrise"];
                Location.Sunset = (string)jsonObject["data"]["weather"][0]["astronomy"][0]["sunset"];
                Location.Cloud = (string)jsonObject["data"]["weather"][0]["hourly"][0]["cloudcover"];
                Location.Lastupdate = (string)jsonObject["data"]["weather"][0]["date"];
                Location.Temperature = (string)jsonObject["data"]["current_condition"][0]["temp_C"];
                Location.Humidity = (string)jsonObject["data"]["current_condition"][0]["humidity"];
                Location.Wind = (string)jsonObject["data"]["current_condition"][0]["windspeedKmph"];
            }
            /// <summary> 
            /// Json parser Exception 
            /// </summary>
            catch (Exception e) { throw new WeatherDataServiceException("Unable to Parse, " + e.Data); }
        }
    }
}

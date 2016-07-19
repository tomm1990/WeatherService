using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherApp.Tests{
    [TestClass()]
    public class WeatherMapTests{
        /// <summary> 
        /// "Weather Map" Test (XML)
        /// </summary>
        [TestMethod()]
        public void getWeatherDataTest(){
            Location location = new Location("West Jerusalem");
            WeatherMap wd = WeatherMap.Instance();
            WeatherData actual = wd.getWeatherData(location);
            Assert.AreEqual(location.Country, actual.Location.Country);
        }
    }
}
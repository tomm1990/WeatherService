using Microsoft.VisualStudio.TestTools.UnitTesting;
/// <remarks>
/// To Support Json - Install Newtonsoft JSON framework
/// </remarks>

namespace WeatherApp.Tests{
    [TestClass()]
    public class WeatherWorldTests{
        /// <summary> 
        /// "Weather World" Test (Json)
        /// </summary>
        [TestMethod()]
        public void getWeatherDataTest(){
            Location location = new Location("Paris, France");
            WeatherWorld wd = WeatherWorld.Instance();
            WeatherData actual = wd.getWeatherData(location);
            Assert.AreEqual(location.Country, actual.Location.Country);
        }
    }
}
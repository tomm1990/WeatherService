using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Tests
{
    [TestClass()]
    public class WeatherMapTests
    {
        [TestMethod()]
        public void getWeatherDataTest()
        {
            Location location = new Location("West Jerusalem");
            WeatherMap wd = WeatherMap.Instance();
            WeatherData actual = wd.getWeatherData(location);
            Assert.AreEqual(location.Country, actual.Location.Country);
        }
    }
}
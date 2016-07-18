using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
/// <remarks>
/// To Support Json - Install Newtonsoft JSON framework
/// </remarks>

namespace WeatherApp.Tests
{
    [TestClass()]
    public class WeatherWorldTests
    {
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
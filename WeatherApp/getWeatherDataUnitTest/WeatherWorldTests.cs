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
    public class WeatherWorldTests
    {
        [TestMethod()]
        public void getWeatherDataTest()
        {
            Location location = new Location("Paris");
            Assert.Fail();
        }
    }
}
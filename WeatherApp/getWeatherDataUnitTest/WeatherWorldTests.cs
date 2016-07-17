﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace WeatherApp.Tests
{
    [TestClass()]
    public class WeatherWorldTests
    {
        [TestMethod()]
        public void getWeatherDataTest()
        {
            Location location = new Location("Paris, France");
            WeatherWorld wd = WeatherWorld.Instance();
           string actual = wd.getWeatherData(location).Location.Country;

            


            Assert.AreEqual(location.Country, actual);
            Assert.Inconclusive("Not Equal\n");
        }

        
    }
}
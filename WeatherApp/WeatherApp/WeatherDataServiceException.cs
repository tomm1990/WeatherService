using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherDataServiceException : ApplicationException
    {
        public WeatherDataServiceException(String message) : base(message)
        {

        }
    }
}

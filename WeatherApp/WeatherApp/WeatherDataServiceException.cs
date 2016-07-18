using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp{
    /// <summary> 
    /// Describes the Exception catch
    /// </summary>
    class WeatherDataServiceException : ApplicationException{
        public WeatherDataServiceException(String message) : base(message){
            Console.WriteLine(message);
        }
    }
}

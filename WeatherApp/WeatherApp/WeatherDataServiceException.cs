using System;

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
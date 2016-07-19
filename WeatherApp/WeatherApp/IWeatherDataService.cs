
namespace WeatherApp{
    /// <summary> 
    /// App Interface
    /// </summary>
    public interface IWeatherDataService{
        WeatherData getWeatherData(Location location);
    }
}
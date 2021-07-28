namespace SASergeev.TestTaskSecond.Models
{
    public class Weather
    {
        private double _temperature;
        private int _humidity;
        private int _sunrise;
        private int _sunset;


        public Weather(double Tempeture, int Humidity, int Sunrise, int Sunset)
        {
            _temperature = Tempeture;
            _humidity = Humidity;
            _sunrise = Sunrise;
            _sunset = Sunset;
        }
        public override string ToString()
        {
            string GetLocalTime(int time) => SunPositon.ConvertToDateLocal(time).ToShortTimeString();
            string GetGlobalTime(int time) => SunPositon.ConvertToDateGMT(time).ToShortTimeString();
            string GetCelsius(double temp) => Temperature.GetCelsius(temp).ToString();
            string GetFahrenheit(double temp) => Temperature.GetFahrenheit(temp).ToString();

            string Weather = $"\nTemperature: {GetCelsius(_temperature)}°C\n" +
                             $"Humidity: {_humidity}%\n";

            string SunPositionGMT = $"GMT TIME\nSunset: { GetGlobalTime(_sunset) }\n" +
                                    $"Sunrise: { GetGlobalTime(_sunrise) }\n";

            string SunPositionLocal = $"LOCAL TIME\nSunset: { GetLocalTime(_sunset) }\n" +
                                    $"Sunrise: { GetLocalTime(_sunrise) }\n";

            return Weather + SunPositionGMT + SunPositionLocal;
        }
        


    }
}

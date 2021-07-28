using Newtonsoft.Json;
using SASergeev.TestTaskSecond.Models;
using System.Net;

namespace SASergeev.TestTaskSecond.Controller
{
    public class WeatherController
    {
        private string _api = "8799342d21f6e63ab6c48327dfabe2a0";
        public string GetWeather(string City)
        {
            string _city = City; 
            string _newLink = $"http://api.openweathermap.org/data/2.5/weather?q={_city}&appid={_api}";
            string _jsonString;
            Weather test;
            using (var WClient = new WebClient())
            {
                try
                {
                    _jsonString = WClient.DownloadString(_newLink);
                    dynamic stuff = JsonConvert.DeserializeObject(_jsonString);
                    double Tempeture = stuff.main.temp;
                    int Humidity = stuff.main.humidity;
                    int SunriseTime = stuff.sys.sunrise;
                    int SunsetTime = stuff.sys.sunset;
                    test = new Weather(Tempeture, Humidity, SunriseTime, SunsetTime);
                    return test.ToString();
                }
                catch (WebException wex)
                {
                        return $"\n{wex.Message}";
                }
            }
        }
    }
}

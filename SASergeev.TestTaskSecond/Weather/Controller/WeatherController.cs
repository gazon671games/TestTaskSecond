using Newtonsoft.Json;
using SASergeev.TestTaskSecond.Models;
using System.Net;

namespace SASergeev.TestTaskSecond.Controller
{
    public class WeatherController
    {
        private string _api = "8799342d21f6e63ab6c48327dfabe2a0";
        public Message GetWeather(string City)
        {
            
            string _city = City;
            if (CityCheck(City))
            {
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
                        var message = new Message(test.ToString(), true);
                        return message;
                    }
                    catch (WebException wex)
                    {
                        var message = new Message($"\n{wex.Message}", false);
                        return message;
                    }
                }
            }
            return new Message($"\nError", false);
            
        }

        private bool CityCheck(string City)
        {
            if (City != string.Empty)
            {
                return true;
            }
                return false;
        }

        public class Message 
        {
            private string _text;
            private bool _flag;
            public Message(string text, bool flag)
            {
                _text = text;
                _flag = flag;
            }
            public override string ToString()
            {
                return _text;
            }
            public bool CheckFlag()
            {
                return _flag;
            }
        }

    }
}

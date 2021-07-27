using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SASergeev.TestTaskSecond.Controller
{
    class WeatherController
    {
        private string _api = "8799342d21f6e63ab6c48327dfabe2a0";
        public void GetWeather()
        {
            string City = Console.ReadLine();
            string NewLink = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={_api}";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(NewLink);
            }
        }


    }
}

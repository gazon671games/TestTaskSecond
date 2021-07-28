using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SASergeev.TestTaskSecond.Controller
{
    static class WeatherConsole
    {
        public static void ConsoleGetWeather()
        {
            string city = CityName();
            var Weather = new WeatherController();
            Console.WriteLine(Weather.GetWeather(city));
            DoitAgain(Weather);

            static void DoitAgain(WeatherController controller)
            {
                var button = PressButton(); 
                while (button.Key != ConsoleKey.Escape)
                {
                    Console.Clear();
                    string city = CityName();
                    Console.WriteLine(controller.GetWeather(city));
                    button = PressButton();
                }
                static ConsoleKeyInfo PressButton()
                {
                    string message = "\nOne more?\nPress any button to continue or ESC to stop";
                    Console.WriteLine(message);
                    ConsoleKeyInfo x = Console.ReadKey();
                    return x;
                }
            }
        }
        private static string CityName()
        {
            string CityName = CityNameGet();
            while (!CityNameCheck(CityName))
            {
                Console.WriteLine("Wrong City-Name, please write it again ");
                CityName = CityNameGet();
            }
            return CityName;
            static bool CityNameCheck(string CityName)
            {

                Regex RegexFirst = new Regex(@"^[\u0000-\u007F]+$");
                if (CityName.All(char.IsLetter) && !CityName.All(char.IsWhiteSpace))
                {
                    return true;
                }
                return false;

            }
            static string CityNameGet()
            {
                Console.WriteLine("Enter a City-Name to get the Weather report");
                string CityName = Console.ReadLine();
                return CityName;
            }
        }
       



    }
}

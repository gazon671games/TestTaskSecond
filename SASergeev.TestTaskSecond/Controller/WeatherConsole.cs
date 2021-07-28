using System;
using System.Linq;
using System.Text.RegularExpressions;
using SASergeev.TestTaskSecond.Models;

namespace SASergeev.TestTaskSecond.Controller
{
    static class WeatherConsole
    {
        public static void ConsoleGetWeather()
        {
            string city = CityName.GetName();
            var Weather = new WeatherController();
            var message = Weather.GetWeather(city);
            string WeatherStatus = message.ToString();
            Console.WriteLine(WeatherStatus);
            if (message.CheckFlag())
            {
                var FileWriterStatus = FileWriterConsole(WeatherStatus);
                Console.WriteLine(FileWriterStatus);
            }
            else { Console.WriteLine("Errors don't come to save"); }
            DoitAgain(Weather);
        }

        static void DoitAgain(WeatherController controller)
        {
            var button = PressButton();
            while (button.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                string city = CityName.GetName();
                Console.WriteLine(controller.GetWeather(city));
                button = PressButton();
            }
        }
        static ConsoleKeyInfo PressButton()
        {
            string message = "\nOne more?\nPress any button to continue or ESC to stop";
            Console.WriteLine(message);
            ConsoleKeyInfo x = Console.ReadKey();
            return x;
        }
        
        private static string FileWriterConsole(string text)
        {
            var newFileWriter = new WeatherFileWriter();
            var result = newFileWriter.SaveQuery(text);
            return result;
        }

    }
}

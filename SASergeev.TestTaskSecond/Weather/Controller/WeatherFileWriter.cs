using System;
using System.IO;

namespace SASergeev.TestTaskSecond.Controller
{
    public class WeatherFileWriter
    {
        private string _currentDate = DateTime.Now.ToShortDateString();
        public string SaveQuery(string text)
        {
            string filename = $"{_currentDate}.txt";
            string path = Directory.GetCurrentDirectory();
            using (var sw = new StreamWriter(filename))
            {
                try
                {
                    sw.WriteLine(text);

                    return $"Weather report is save\nPath is {path}\nFile name is {filename}";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}

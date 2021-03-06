using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SASergeev.TestTaskSecond.Models
{
    public static class CityName
    {
        public static string GetName()
        {
            string CityName = NameGet();

            if (!NameCheck(CityName))
            {
                Console.WriteLine("Wrong City-Name");
                return "";
            }
            return CityName;

            static bool NameCheck(string CityName)
            {
                if (CityName.All(char.IsLetter) && !CityName.All(char.IsWhiteSpace))
                {
                    return true;
                }
                return false;
            }
            static string NameGet()
            {
                Console.WriteLine("Enter a City-Name to get the Weather report");
                string CityName = Console.ReadLine();
                return CityName;
            }
        }

    }
}

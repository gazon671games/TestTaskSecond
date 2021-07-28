

namespace SASergeev.TestTaskSecond.Models
{
    static class Temperature
    {
        public static int GetCelsius(double tempeture)
        {
            int Celsius = (int)(tempeture - 273.15);
            return Celsius;
        }

        public static  double GetFahrenheit(double tempeture)
        {
            double Fahrenheit = (int)((tempeture - 273.15)*9/5+32);
            return Fahrenheit;
        }

    }
}

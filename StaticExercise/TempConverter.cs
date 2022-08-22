using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return Math.Round(((fahrenheit - 32) * .5556));
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return Math.Round(((celsius * 1.8) + 32));
        }

    }
}

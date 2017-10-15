using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static double FahrenneitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void Main()
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenneitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }
    }
}

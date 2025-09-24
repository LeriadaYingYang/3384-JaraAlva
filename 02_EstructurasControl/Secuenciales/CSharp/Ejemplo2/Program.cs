using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Conversión de temperaturas*/
            Console.Write("Ingrese temperatura en Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("En Fahrenheit: " + fahrenheit);
            Console.WriteLine("En Kelvin: " + kelvin);
        }
    }
}

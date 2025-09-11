using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practicamos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hallar la hipotenusa de un triángulo rectángulo.
            Console.WriteLine("Ingrese el primer lado (cateto A): ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado (cateto B): ");
            double b = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("El resultado de la hipotenusa es: " + r);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elabore un algoritmo que resuelva las raíces reales cuadráticas.*/
            double a, b, c, discriminante, raiz1, raiz2;
            Console.WriteLine("Ingrese el valor de a: ");a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b: ");b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de c: ");c = Convert.ToDouble(Console.ReadLine());
            discriminante = (b * b) - (4 * a * c);
            if (discriminante > 0)
            {
                raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las raíces son reales y diferentes.");
                Console.WriteLine("Raíz 1: " + raiz1);
                Console.WriteLine("Raíz 2: " + raiz2);
            }
            else if (discriminante == 0)
            {
                raiz1 = raiz2 = -b / (2 * a);
                Console.WriteLine("Las raíces son reales e iguales.");
                Console.WriteLine("Raíz única: " + raiz1);
            }
            else
            {
                Console.WriteLine("No existen raíces reales.");
            }
            Console.ReadKey();
        }
    }
}

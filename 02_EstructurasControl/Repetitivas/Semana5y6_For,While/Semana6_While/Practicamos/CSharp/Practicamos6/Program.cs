using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicamos6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Hacer que nuestro programa escriba en pantalla 1000 veces el texto “Todos los días reviso dos problemas de algoritmos”*/

            int i = 1;
            while (i <= 1000)
            {
                Console.WriteLine(i + ". Todos los días reviso dos problemas de algoritmos");
                i++;
            }
            /*2. Indicar si un número es perfecto, cuando la suma de sus divisores es igual al número. Por ejemplo 6, tiene como divisores a 1,2 y 3, luego 1+2+3=6.*/
            Console.Write("Ingrese un número: ");
            int num2 = int.Parse(Console.ReadLine());
            int suma2 = 0, i2 = 1;

            while (i2 < num2)
            {
                if (num2 % i == 0)
                    suma2 += i;
                i2++;
            }

            if (suma2 == num2)
                Console.WriteLine(num2 + " es un número perfecto.");
            else
                Console.WriteLine(num2 + " no es un número perfecto.");

            Console.ReadKey();
        }
    }
}

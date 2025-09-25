using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicamos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Programa que presente la tabla de multiplicar */

            Console.Write("Ingrese el número de la tabla: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabla de multiplicar del " + n);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            /*2.Programa que imprima *  */

            for (int i2 = 1; i2 <= 6; i2++)
            {
                for (int j = 1; j <= i2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

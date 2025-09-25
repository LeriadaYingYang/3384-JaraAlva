using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cómo podría escribir un algoritmo que lea un carácter y dependiendo del carácter ingresado (‘s’, ‘c’, ‘v’, ‘d’, otro cualquiera) nos imprima:
            . Soltero

            . Casado

            . Viudo

            . Divorciado

            . Sin especificar

            . Plantear alternativas*/

            char ec;
            Console.WriteLine("Estado civil:");
            ec = char.Parse(Console.ReadLine());

            switch (ec)
            {
                case 's':
                    Console.WriteLine("Soltero");
                    break;
                case 'c':
                    Console.WriteLine("Casado");
                    break;
                case 'v':
                    Console.WriteLine("Viudo");
                    break;
                case 'd':
                    Console.WriteLine("Divorciado");
                    break;
                default:
                    Console.WriteLine("Sin especificar");
                    break;
            }

            Console.ReadKey();

        }
    }
}

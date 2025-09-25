using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Evaluar el valor de un número entero y determinar si es positivo, negativo o neutro (cero).*/
            Console.WriteLine("Valor para x:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                if (x < 0)
                {
                    Console.WriteLine("Negativo");
                }
                else
                {
                    Console.WriteLine("Neutro");
                }
            }
            Console.ReadKey();
        }
    }
}

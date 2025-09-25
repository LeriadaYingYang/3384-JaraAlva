using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida un número y determine si es par o impar.*/

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es PAR");
            }
            else
            {
                Console.WriteLine("El número es IMPAR");
            }

            Console.ReadKey();
        }
    }
}

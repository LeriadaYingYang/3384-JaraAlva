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
            int n, digito;

            Console.Write("Ingrese un número entero: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Número invertido: ");

            do
            {
                digito = n % 10;
                Console.Write(digito);
                n = n / 10;
            }
            while (n > 0);

            Console.WriteLine();
        }
    }
}

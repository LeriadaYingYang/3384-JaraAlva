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
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Número invertido: ");
            invertir(numero);

            Console.ReadKey();
        }

        static void invertir(int x)
        {
            do
            {
                int residuo = x % 10;
                Console.Write(residuo);
                x = x / 10;
            } while (x > 0);
        }
    }
}

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
            /*Leer 2 números a y b, en el caso de que a sea mayor que b intercambiar sus valores, de lo contrario no hacer nada.*/
            int a, b;

            Console.WriteLine("Valor de a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de b:");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Valor de a: " + a);
            Console.WriteLine("Valor de b: " + b);
            Console.ReadKey();
        }
    }
}

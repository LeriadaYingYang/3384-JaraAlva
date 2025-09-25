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
            /*Leer 2 números a y b, en el caso de que a sea menor que b intercambiar sus valores, de lo contrario incrementar sus valores en 1.*/
            int a, b;

            Console.Write("Ingrese el valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de b: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            else
            {
                a = a + 1;
                b = b + 1;
            }

            Console.WriteLine("Nuevo valor de a: " + a);
            Console.WriteLine("Nuevo valor de b: " + b);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leer 2 números a y b, en el caso de que a sea mayor que b intercambiar sus valores, de lo contrario no incrementar sus valores en 1.*/
            int a, b, temp;
            Console.WriteLine("Ingrese el valor de a: ");a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b: ");b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("Los valores han sido intercambiados.");
            }
            else
            {
                a++;
                b++;
                Console.WriteLine("Los valores han sido incrementados en 1.");
            }
            Console.WriteLine("Valor de a: " + a);
            Console.WriteLine("Valor de b: " + b);
            Console.ReadKey();
        }
    }
}

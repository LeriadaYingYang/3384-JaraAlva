using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*programa que pida un número entero n y calcule la suma de los primeros n números naturales.*/
            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma += i; // equivalente a suma = suma + i
            }

            Console.WriteLine("La suma de los primeros " + n + " números es: " + suma);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_001
{
    internal class Program
    {
        /*solicita al usuario un número entero n, que representa la cantidad de elementos a usar. Luego, mediante un ciclo while, calcula la suma de los n primeros números impares.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Número de elementos a usar:");
            int n = int.Parse(Console.ReadLine());
            sumar(n);
            Console.ReadKey();
        }

        static void sumar(int n)
        {
            int impar = 1;
            int suma = 0;
            while (n > 0)
            {
                suma = suma + impar;
                impar = impar + 2;
                n = n - 1;
            }
            Console.WriteLine("La suma es:" + suma);
        }

    }
}

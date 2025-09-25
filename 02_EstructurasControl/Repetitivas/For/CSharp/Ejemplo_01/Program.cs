using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*calcula la suma de los cuadrados de los primeros n números enteros.*/
            int n;
            Console.WriteLine("Número de elementos");
            n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i * i;
            }
            Console.WriteLine("Suma:" + suma);
            Console.ReadKey();

        }
    }
}

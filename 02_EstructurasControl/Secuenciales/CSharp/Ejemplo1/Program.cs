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
            /*¿Cómo calcular el área de un triángulo en base a sus 3 lados?*/

            Console.WriteLine("Ingrese lado A:");
            int la = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado B:");
            int lb = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado C:");
            int lc = int.Parse(Console.ReadLine());

            double s = (la + lb + lc) / 2.0;
            double area = Math.Sqrt(s * (s - la) * (s - lb) * (s - lc));

            Console.WriteLine("El área es:" + area);
            Console.ReadKey();

        }
    }
}

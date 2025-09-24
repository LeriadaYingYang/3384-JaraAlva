using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Qué pasaría si me piden calcular el volumen del tronco de un cono ¿cómo lo resuelvo?*/

            Console.Write("Ingrese el radio mayor (r1): ");
            double r1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el radio menor (r2): ");
            double r2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura (h): ");
            double h = double.Parse(Console.ReadLine());

            double S1 = Math.PI * r1 * r1;
            double S2 = Math.PI * r2 * r2;

            double volumen = (h / 3.0) * (S1 + S2 + Math.Sqrt(S1 * S2));

            Console.WriteLine("El volumen del tronco de cono es: " + volumen);

        }
    }
}

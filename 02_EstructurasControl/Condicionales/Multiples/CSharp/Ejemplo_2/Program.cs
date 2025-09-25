using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida la nota de un estudiante y muestre su calificación:
            0 a 10 → "Desaprobado"

            11 a 15 → "Regular"

            16 a 20 → "Excelente"*/

            Console.Write("Ingrese la nota (0-20): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                Console.WriteLine("Desaprobado");
            }
            else if (nota >= 11 && nota <= 15)
            {
                Console.WriteLine("Regular");
            }
            else if (nota >= 16 && nota <= 20)
            {
                Console.WriteLine("Excelente");
            }
            else
            {
                Console.WriteLine("Nota fuera de rango");
            }

            Console.ReadKey();
        }
    }
}

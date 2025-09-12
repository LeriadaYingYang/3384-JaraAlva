using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dado un número, si es menor que cero, hallar su valor absoluto, de lo contrario, mostrar la raíz cuadrada*/
            Console.WriteLine("Ingrese un numero:");double num = double.Parse(Console.ReadLine());
            if (num < 0)
            {
                double valorAbsoluto = Math.Abs(num);
                Console.WriteLine("El valor absoluto es: " + valorAbsoluto);
            }
            else
            {
                double raizCuadrada = Math.Sqrt(num);
                Console.WriteLine("La raiz cuadrada es: " + raizCuadrada);
            }
            Console.ReadKey();
        }
    }
}

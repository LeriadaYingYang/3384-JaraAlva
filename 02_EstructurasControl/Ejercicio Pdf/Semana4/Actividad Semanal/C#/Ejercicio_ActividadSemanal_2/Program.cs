using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ActividadSemanal_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*Elaborar un programa que verifique si un número es impar y
múltiplo de 5.*/
            int numero;
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 != 0 && numero % 5 == 0)
            {
                Console.WriteLine($"El número {numero} es impar y múltiplo de 5.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no cumple con las condiciones.");
            }
            Console.ReadKey();
        }
    }
}

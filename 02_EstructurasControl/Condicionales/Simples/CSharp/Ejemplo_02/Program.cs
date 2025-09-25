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
            /*Un programa que pida la edad de una persona y muestre un mensaje si es mayor de edad.*/
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }

            Console.ReadKey();
        }
    }
}

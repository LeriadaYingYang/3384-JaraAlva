using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar un programa que pida dos números y verifique si son iguales*/
            Console.WriteLine("Ingrese el primer numero:");int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                Console.WriteLine("Los numeros no son iguales");
            }
            Console.ReadKey();
        }
    }
}

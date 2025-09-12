using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Encuentre el mayor valor de tres números dados*/
            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer número:");num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("El mayor número es: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("El mayor número es: " + num2);
            }
            else
            {
                Console.WriteLine("El mayor número es: " + num3);
            }
        }
    }
}

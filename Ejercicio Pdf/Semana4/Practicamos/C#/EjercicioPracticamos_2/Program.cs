using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ordene de mayor a menor tres números ingresados por teclado*/
            int num1, num2, num3, mayor, medio, menor;
            Console.WriteLine("Ingrese el primer número:");num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
                if (num2 >= num3)
                {
                    medio = num2;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num2;
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
                if (num1 >= num3)
                {
                    medio = num1;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num1;
                }
            }
            else
            {
                mayor = num3;
                if (num1 >= num2)
                {
                    medio = num1;
                    menor = num2;
                }
                else
                {
                    medio = num2;
                    menor = num1;
                }
            }
            Console.WriteLine("Los números ordenados de mayor a menor son: " + mayor + ", " + medio + ", " + menor);
        }
    }
}

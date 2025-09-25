using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticamos_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar un programa que calcule el promedio de 4 notas y muestre “aprobado” si su promedio es mayor o igual que 12*/
            Console.WriteLine("Ingrese la primera nota:");float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");float nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota:");float nota4 = float.Parse(Console.ReadLine());
            float promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            if (promedio >= 12)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }
            Console.ReadKey();
        }
    }
}

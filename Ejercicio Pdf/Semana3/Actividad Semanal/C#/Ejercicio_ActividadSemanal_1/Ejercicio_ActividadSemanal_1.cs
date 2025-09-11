using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ActividadSemanal_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular el área y el perímetro de un terreno rectangular.
            Console.WriteLine("Ingrese la Base del terreno rectangular:");
            double baserec = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del terreno rectangular");
            double altura = double.Parse(Console.ReadLine());
            double area = baserec * altura;
            double perimetro = 2 * (baserec + altura);
            Console.WriteLine("El Area del terreno rectangular es de: " + area);
            Console.WriteLine("El perimetro del terreno rectangular es de: " + perimetro);
        }
    }
}

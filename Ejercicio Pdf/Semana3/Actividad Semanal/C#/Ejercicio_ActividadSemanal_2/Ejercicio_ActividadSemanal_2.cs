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
            //Hallar el volumen del cilindro.
            Console.WriteLine("Ingrese el radio: ");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la alatura del cilindro: ");
            double altura = double.Parse(Console.ReadLine());
            double volumen = Math.PI * (Math.Pow(radio, 2)) * altura;
            Console.WriteLine("El volumen del cilindro es : " + volumen);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ActividadSemanal_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hallar el área y el volumen de un paralelepípedo.
            Console.WriteLine("Ingrese el lado de largo: ");
            double largo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho:");
            double ancho = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el alto:");
            double alto = double.Parse(Console.ReadLine());

            double area = 2 * ((largo * ancho) + (largo * alto) + (ancho * alto));
            double volumen = (largo * ancho * alto);

            Console.WriteLine("El area es de : " + area);
            Console.WriteLine("El volumen es de : " + volumen);
            Console.ReadKey();
        }
    }
}

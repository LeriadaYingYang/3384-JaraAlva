using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cálculo de sueldo con descuento de impuestos del 8% de impuesto*/
            Console.Write("Ingrese el sueldo base: ");
            double sueldoBase = double.Parse(Console.ReadLine());

            double descuento = sueldoBase * 0.08;
            double sueldoNeto = sueldoBase - descuento;

            Console.WriteLine("El descuento aplicado es: " + descuento);
            Console.WriteLine("El sueldo neto es: " + sueldoNeto);
            Console.ReadKey();

        }
    }
}

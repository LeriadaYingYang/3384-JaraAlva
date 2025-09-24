using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practicamos_4
{
    internal class Ejercicio_Practicamos_4
    {
        static void Main(string[] args)
        {
            //Hallar el sueldo neto de un trabajador en base al sueldo base, sabiendo que se le descuenta por AFP 10% del sueldo neto y 5% de seguro de vida. Además, se le considera un bono extra de 85 soles por escolaridad.
            Console.Write("Ingrese el sueldo base del trabajador: ");
            double sueldo = double.Parse(Console.ReadLine());
            double descuento_afp = sueldo * 0.10;
            double descuento_vida = sueldo * 0.05;
            double bono = 85;
            double sueldo_neto = sueldo - descuento_afp - descuento_vida + bono;
            Console.WriteLine("El sueldo neto del trabajador es: " + sueldo_neto);
            Console.ReadKey();
        }
    }
}

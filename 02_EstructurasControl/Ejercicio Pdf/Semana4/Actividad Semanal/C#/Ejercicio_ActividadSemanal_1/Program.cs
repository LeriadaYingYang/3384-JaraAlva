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
/*Elaborar un programa que calcule el impuesto de la renta a
pagar (5%), solo si su monto de renta supera las 7 UITS*/
            const double UIT = 5250;
            const double IMPUESTO = 0.05;
            double montoRenta, rentaAnual, impuestoRenta;
            Console.Write("Ingrese su monto de renta mensual: ");
            montoRenta = Convert.ToDouble(Console.ReadLine());
            rentaAnual = montoRenta * 12;
            if (rentaAnual > (7 * UIT))
            {
                impuestoRenta = rentaAnual * IMPUESTO;
                Console.WriteLine($"El impuesto a pagar es: S/{impuestoRenta}");
            }
            else
            {
                Console.WriteLine("No paga impuesto de la renta");
            }
            Console.ReadKey();
        }
    }
}

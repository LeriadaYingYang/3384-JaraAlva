using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ActividadSemanal_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hallar el costo total a pagar por estacionamiento si el monto por hora cuesta S/. 2.5.
            Console.WriteLine("Ingrese las horas estacionadas del cliente:");
            double horas = double.Parse(Console.ReadLine());
            double monto = horas * 2.50;
            Console.WriteLine("El monto a pagar es de: s/. " + monto);
            Console.ReadKey();
        }
    }
}

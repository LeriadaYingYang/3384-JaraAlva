using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ActividadSemanal_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular el equivalente de metros en pulgadas.
            Console.WriteLine("Ingrese los metros que quiere convertir a Pulgadas: ");
            double metro = double.Parse(Console.ReadLine());
            double pulgadas = metro * 39.3701;
            Console.WriteLine("El Resultado en pulgadas es de : " + pulgadas);
        }
    }
}

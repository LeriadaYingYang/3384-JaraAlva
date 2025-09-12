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
/*Calcular el pago a recibir en base a las horas trabajadas y la tarifa ingresada. Si existen horas extra al jornal semanal
 * máximo (40 horas) deberá considerar un pago extra del 15% por la diferencia de horas.*/
            int horasTrabajadas;
            double tarifaHora, pagoTotal;
            const int horasMaximas = 40;
            const double porcentajeExtra = 0.15;
            Console.Write("Ingrese la cantidad de horas trabajadas en la semana: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la tarifa por hora: ");
            tarifaHora = Convert.ToDouble(Console.ReadLine());
            if (horasTrabajadas > horasMaximas)
            {
                int horasExtra = horasTrabajadas - horasMaximas;
                double pagoHorasNormales = horasMaximas * tarifaHora;
                double pagoHorasExtra = horasExtra * tarifaHora * (1 + porcentajeExtra);
                pagoTotal = pagoHorasNormales + pagoHorasExtra;
            }
            else
            {
                pagoTotal = horasTrabajadas * tarifaHora;
            }
            Console.WriteLine($"El pago total a recibir es: {pagoTotal:C}");
            Console.ReadKey();
        }
    }
}

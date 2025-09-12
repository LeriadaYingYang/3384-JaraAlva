using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_ActividadSemanal_
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*Generar un número aleatorio entre 1 y 5, y de acuerdo con el número
obtenido indicar qué premio obtuvo:
• <1> 0 soles
• <2> 5 soles
• <3> 10 soles
• <4> 20 soles
• <5> 50 soles
ACTIVIDAD SEMANAL*/
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 6);
            int premio;
            switch (numeroAleatorio)
            {
                case 1:
                    premio = 0;
                    break;
                case 2:
                    premio = 5;
                    break;
                case 3:
                    premio = 10;
                    break;
                case 4:
                    premio = 20;
                    break;
                case 5:
                    premio = 50;
                    break;
                default:
                    premio = 0;
                    break;
            }
            Console.WriteLine($"Número aleatorio: {numeroAleatorio}");
            Console.WriteLine($"Premio obtenido: {premio} soles");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En el proceso de admisión de una universidad pública, el costo de inscripción es de
240 soles, en la tabla se muestra el monto que deberá ser agregado a la inscripción.
Si un postulante es hijo de un trabajador de la universidad no paga inscripción.
Elaborar un programa que pida el tipo de colegio, lugar de nacimiento y si es hijo de
trabajador universitario; luego de ello calcular el monto a pagar.*/

            int costoInscripcion = 240;
            int montoExtra = 0;

            Console.WriteLine("¿Es hijo de trabajador universitario? (si/no): ");
            string trabajador = Console.ReadLine().ToLower();

            if (trabajador == "si")
            {
                Console.WriteLine("Monto a pagar: 0");
            }
            else
            {
                Console.WriteLine("Tipo de colegio (estatal/particular): ");
                string colegio = Console.ReadLine().ToLower();

                Console.WriteLine("Lugar de nacimiento (cajamarca/provincia/otra): ");
                string lugar = Console.ReadLine().ToLower();

                if (lugar == "cajamarca")
                {
                    if (colegio == "estatal")
                        montoExtra = 0;
                    else
                        montoExtra = 30;
                }
                else if (lugar == "provincia")
                {
                    if (colegio == "estatal")
                        montoExtra = 20;
                    else
                        montoExtra = 50;
                }
                else // otra provincia
                {
                    if (colegio == "estatal")
                        montoExtra = 100;
                    else
                        montoExtra = 150;
                }

                int total = costoInscripcion + montoExtra;
                Console.WriteLine("Monto a pagar: " + total);
            }

            Console.ReadKey();
        }
    }
}

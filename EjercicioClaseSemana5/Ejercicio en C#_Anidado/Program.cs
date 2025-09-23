using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_C__Anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En el proceso de admisión de una universidad pública, el costo de inscripción es de 240 soles, en la tabla se muestra el monto que deberá ser agregado a la inscripción.
            Si un postulante es hijo de un trabajador de la universidad no paga inscripción.
            Elaborar un programa que pida el tipo de colegio, lugar de nacimiento y si es hijo de trabajador universitario; luego de ello calcular el monto a pagar.*/

            int baseInscripcion = 240;
            int adicional = 0;

            Console.Write("Tipo de colegio (E = Estatal, P = Particular): ");
            char colegio = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            Console.WriteLine("Lugar de nacimiento:");
            Console.WriteLine("1. Cajamarca");
            Console.WriteLine("2. Provincia de Cajamarca");
            Console.WriteLine("3. Otra provincia");
            Console.Write("Elija opción (1-3): ");
            int lugar = int.Parse(Console.ReadLine());

            Console.Write("¿Es hijo de trabajador universitario? (S/N): ");
            char hijoTrabajador = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (hijoTrabajador == 'S')
            {
                Console.WriteLine("\nMonto a pagar: S/ 0");
                return;
            }

            if (lugar == 1)
            {
                if (colegio == 'E') adicional = 0;
                else if (colegio == 'P') adicional = 30;
            }
            else if (lugar == 2)
            {
                if (colegio == 'E') adicional = 20;
                else if (colegio == 'P') adicional = 50;
            }
            else if (lugar == 3)
            {
                if (colegio == 'E') adicional = 100;
                else if (colegio == 'P') adicional = 150;
            }

            int total = baseInscripcion + adicional;

            Console.WriteLine($"\nMonto a pagar: S/ {total}");

        }
    }
}

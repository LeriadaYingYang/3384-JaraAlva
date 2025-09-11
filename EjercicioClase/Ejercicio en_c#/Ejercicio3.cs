using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Multiple
{
    public class Menu
    {
        public void menuopciones()
        {
            Console.WriteLine("Menu de Opciones");
            Console.WriteLine("1. Algoritmo secuencias");
            Console.WriteLine("2. Algoritmo condicionales simple");
            Console.WriteLine("3. Algoritmo condicionales doble");
            Console.WriteLine("4. Algoritmo condicionales anidado");
            Console.WriteLine("Seleccione una opcion");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Algoritmo Secuencial");
                    int costo = 2;
                    Console.WriteLine("Ingrese Km de viaje: ");
                    var km = int.Parse(Console.ReadLine());
                    var costotransporte = costo * km;
                    Console.WriteLine($"El pago por el viaje de {km} Km es: {costotransporte} soles");
                    break;

            }
        }
    }
}
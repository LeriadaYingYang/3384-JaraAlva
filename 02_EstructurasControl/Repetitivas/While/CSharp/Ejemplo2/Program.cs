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
            /*Genera un número secreto entre 1 y 20 y usa un while para que el usuario lo adivine, contando los intentos hasta acertar.*/

            Random rnd = new Random();
            int secreto = rnd.Next(1, 21);
            int intentos = 0;
            int numero = 0;

            Console.WriteLine("Adivina el número (entre 1 y 20):");

            while (numero != secreto)
            {
                Console.Write("Ingresa tu intento: ");
                numero = int.Parse(Console.ReadLine());
                intentos++;

                if (numero == secreto)
                {
                    Console.WriteLine("¡Correcto! Adivinaste en " + intentos + " intentos.");
                }
                else if (numero < secreto)
                {
                    Console.WriteLine("El número es mayor.");
                }
                else
                {
                    Console.WriteLine("El número es menor.");
                }
            }

            Console.ReadKey();

        }
    }
}

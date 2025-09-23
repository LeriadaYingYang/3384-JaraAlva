using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creando Ejemplos para probar el Control de Versiones iniciando con el Hola Mundo*/
            Console.WriteLine("Hola Mundo");
            /*Creando la suma y resta*/
            int a; int b;
            Console.WriteLine("Ejemplo de Suma y Resta");
            Console.WriteLine("Ingrese el primer numero");a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + (a + b));
            Console.WriteLine("La resta es: " + (a - b));
            /*Creando hasta un numero fijo que ingrese el usuario el sistema le de solo los pares*/
            int n;
            Console.WriteLine("Ingrese un numero para mostrarle los pares hasta ese numero");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            /*Ruleta de la suerte del 1 al 10 */
            Random r = new Random();
            int numero = r.Next(1, 11);
            int intento;
            Console.WriteLine("Bienvenido a la ruleta de la suerte, tienes 3 intentos para adivinar el numero del 1 al 10");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Intento " + i + ": Ingrese su numero");
                intento = Convert.ToInt32(Console.ReadLine());
                if (intento == numero)
                {
                    Console.WriteLine("Felicidades, has adivinado el numero");
                    break;
                }
                else
                {
                    Console.WriteLine("Lo siento, ese no es el numero");
                    if (i == 3)
                    {
                        Console.WriteLine("El numero era: " + numero);
                    }
                }
            }
            Console.ReadKey();



        }
    }
}

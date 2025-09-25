using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemanal6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Encontrar la suma de n números ingresados por el teclado.*/

            Console.Write("Ingrese la cantidad de números: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0, i = 1;

            while (i <= n)
            {
                Console.Write("Ingrese el número " + i + ": ");
                int num = int.Parse(Console.ReadLine());
                suma += num;
                i++;
            }

            Console.WriteLine("La suma es: " + suma);

            /*2. Encontrar la suma de n números aleatorios.*/

            Console.Write("Ingrese la cantidad de números aleatorios: ");
            int n2 = int.Parse(Console.ReadLine());
            Random rnd2 = new Random();
            int suma2 = 0, i2 = 1;

            while (i2 <= n2)
            {
                int num1 = rnd2.Next(1, 101);
                Console.WriteLine("Número " + i2 + ": " + num1);
                suma2 += num1;
                i2++;
            }

            Console.WriteLine("La suma de los números aleatorios es: " + suma2);

            /*3. Diseñar un programa que calcule el promedio de las notas ingresadas por consola. Cuando el
usuario ingrese una nota igual a cero o negativa se dejarán de ingresar las notas.*/

            int suma3 = 0, contador3 = 0;
            int nota3;

            Console.WriteLine("Ingrese las notas (0 o negativas para terminar):");

            nota3 = int.Parse(Console.ReadLine());

            while (nota3 > 0)
            {
                suma3 += nota3;
                contador3++;
                nota3 = int.Parse(Console.ReadLine());
            }

            if (contador3 > 0)
            {
                double promedio3 = (double)suma3 / contador3;
                Console.WriteLine("Promedio de notas: " + promedio3);
            }
            else
            {
                Console.WriteLine("No se ingresaron notas válidas.");
            }
            Console.ReadKey();




        }
    }
}

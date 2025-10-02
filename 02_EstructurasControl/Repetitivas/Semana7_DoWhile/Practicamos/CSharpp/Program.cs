using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. */
            {
                int n, i = 1;
                int num, suma = 0, producto = 1;

                Console.Write("¿Cuántos números desea ingresar?: ");
                n = int.Parse(Console.ReadLine());

                do
                {
                    Console.Write("Ingrese el número {0}: ", i);
                    num = int.Parse(Console.ReadLine());

                    suma += num;
                    producto *= num;

                    i++;
                } while (i <= n);

                double promedio = (double)suma / n;

                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Promedio: " + promedio);
            }
            /*2. */
            {
                int n2, i2 = 1;
                int num2, mayor2;

                Console.Write("¿Cuántos números desea ingresar?: ");
                n2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el número 1: ");
                num2 = int.Parse(Console.ReadLine());
                mayor2 = num2;

                i2 = 2;
                do
                {
                    Console.Write("Ingrese el número {0}: ", i2);
                    num2 = int.Parse(Console.ReadLine());

                    if (num2 > mayor2)
                        mayor2 = num2;

                    i2++;
                } while (i2 <= n2);

                Console.WriteLine("El mayor número es: " + mayor2);
            }
            /*3. */
            {
                int n3, i3 = 3;
                int a3 = 1, b3 = 1, c3;

                Console.Write("¿Cuántos términos de Fibonacci desea mostrar?: ");
                n3 = int.Parse(Console.ReadLine());

                Console.Write("Serie de Fibonacci: ");
                Console.Write(a3 + " " + b3);

                do
                {
                    c3 = a3 + b3;
                    Console.Write(" " + c3);

                    a3 = b3;
                    b3 = c3;

                    i3++;
                } while (i3 <= n3);

                Console.WriteLine();
            }
            /*4. */
            {
                int opcion4;
                double a4 = 0, b4 = 0;

                do
                {
                    Console.WriteLine("\nMENÚ:");
                    Console.WriteLine("[1] Leer números A y B");
                    Console.WriteLine("[2] Suma");
                    Console.WriteLine("[3] Producto");
                    Console.WriteLine("[4] División");
                    Console.WriteLine("[5] Salir");
                    Console.Write("Elija una opción: ");
                    opcion4 = int.Parse(Console.ReadLine());

                    switch (opcion4)
                    {
                        case 1:
                            Console.Write("Ingrese A: ");
                            a4 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese B: ");
                            b4 = double.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.WriteLine("Suma: " + (a4 + b4));
                            break;

                        case 3:
                            Console.WriteLine("Producto: " + (a4 * b4));
                            break;

                        case 4:
                            if (b4 != 0)
                                Console.WriteLine("División: " + (a4 / b4));
                            else
                                Console.WriteLine("No se puede dividir entre cero.");
                            break;
                    }

                } while (opcion4 != 5);

                Console.WriteLine("Programa finalizado.");
            }

        }
    }
}

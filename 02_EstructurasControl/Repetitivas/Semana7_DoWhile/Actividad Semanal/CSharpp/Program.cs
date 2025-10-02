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
            /*1*/

            {
                int num1, i1 = 1;
                long factorial1 = 1;

                Console.Write("Ingrese un número: ");
                num1 = int.Parse(Console.ReadLine());

                do
                {
                    factorial1 *= i1;
                    i1++;
                } while (i1 <= num1);

                Console.WriteLine("El factorial de {0} es: {1}", num1, factorial1);
            }

            /*2*/

            {
                int a2, b2;

                Console.Write("Ingrese el valor de a: ");
                a2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor de b: ");
                b2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Números pares entre {0} y {1}:", a2, b2);

                int i2 = a2;
                do
                {
                    if (i2 % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i2++;
                } while (i2 <= b2   );
            }


            /*3*/

            {
                int n3, i3 = 1;
                int num3, mayor3, menor3, suma3 = 0;

                Console.Write("¿Cuántos números desea ingresar?: ");
                n3 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el número 1: ");
                num3 = int.Parse(Console.ReadLine());

                mayor3 = num3;
                menor3 = num3;
                suma3 = num3;

                i3 = 2;
                do
                {
                    Console.Write("Ingrese el número {0}: ", i3);
                    num3 = int.Parse(Console.ReadLine());

                    if (num3 > mayor3)
                        mayor3 = num3;

                    if (num3 < menor3)
                        menor3 = num3;

                    suma3 += num3;
                    i3++;
                } while (i3 <= n3);

                double promedio3 = (double)suma3 / n3;

                Console.WriteLine("Mayor: " + mayor3);
                Console.WriteLine("Menor: " + menor3);
                Console.WriteLine("Promedio: " + promedio3);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1*/
            int x, y;
            Console.Write("Ingrese el valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de y: ");
            y = int.Parse(Console.ReadLine());

            int contador = 0;
            if (x % 2 != 0)
            {
                x++;
            }
            Console.WriteLine("Números pares entre los valores ingresados:");
            while (x <= y)
            {
                Console.WriteLine(x);
                contador++;
                x += 2;
            }
            Console.WriteLine("Cantidad de números pares: " + contador);

            /*2*/
            int inicio, fin;
            Console.Write("Ingrese el límite inferior del rango: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el límite superior del rango: ");
            fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Números perfectos en el rango dado:");
            int num = inicio;
            while (num <= fin)
            {
                int sumaDivisores = 0;
                int divisor = 1;
                while (divisor < num)
                {
                    if (num % divisor == 0)
                    {
                        sumaDivisores += divisor;
                    }
                    divisor++;
                }
                if (sumaDivisores == num && num != 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }

            /*3*/
            int num3 = 100;
            Console.WriteLine("Números primos de tres dígitos:");
            while (num3 <= 999)
            {
                int divisor3 = 2;
                bool esPrimo3 = true;
                while (divisor3 <= num3 / 2)
                {
                    if (num3 % divisor3 == 0)
                    {
                        esPrimo3 = false;
                        break;
                    }
                    divisor3++;
                }
                if (esPrimo3)
                {
                    Console.WriteLine(num3);
                }
                num3++;
            }

            /*4*/
            int num4 = 0;
            int fin4 = 999;
            Console.WriteLine("Números Armstrong (cubos perfectos):");
            while (num4 <= fin4)
            {
                int temp4 = num4;
                int sumaCubos4 = 0;
                while (temp4 > 0)
                {
                    int digito4 = temp4 % 10;
                    sumaCubos4 += digito4 * digito4 * digito4;
                    temp4 /= 10;
                }
                if (sumaCubos4 == num4)
                {
                    Console.WriteLine(num4);
                }
                num4++;
            }

            /*5*/
            Console.Write("Ingrese el valor de n: ");
            int n5 = int.Parse(Console.ReadLine());
            int a5 = 2;
            Console.WriteLine("Pares de números amigos menores que " + n5 + ":");
            while (a5 < n5)
            {
                int sumaA5 = 0;
                int i5 = 1;
                while (i5 < a5)
                {
                    if (a5 % i5 == 0)
                    {
                        sumaA5 += i5;
                    }
                    i5++;
                }
                int b5 = sumaA5;
                if (b5 > a5 && b5 < n5)
                {
                    int sumaB5 = 0;
                    int j5 = 1;
                    while (j5 < b5)
                    {
                        if (b5 % j5 == 0)
                        {
                            sumaB5 += j5;
                        }
                        j5++;
                    }
                    if (sumaB5 == a5)
                    {
                        Console.WriteLine(a5 + " y " + b5);
                    }
                }
                a5++;
            }

            /*6*/
            int inicio6, fin6;
            Console.Write("Ingrese el límite inferior del rango: ");
            inicio6 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el límite superior del rango: ");
            fin6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Números capicúas en el rango dado:");
            int num6 = inicio6;
            while (num6 <= fin6)
            {
                int original6 = num6;
                int invertido6 = 0;
                int temp6 = num6;
                while (temp6 > 0)
                {
                    int digito6 = temp6 % 10;
                    invertido6 = invertido6 * 10 + digito6;
                    temp6 /= 10;
                }
                if (original6 == invertido6)
                {
                    Console.WriteLine(num6);
                }
                num6++;
            }

            /*7*/
            Console.Write("Ingrese la cantidad de números: ");
            int n7 = int.Parse(Console.ReadLine());
            int contador7 = 1;
            int mayor7, menor7;
            double suma7 = 0;
            Console.Write("Ingrese el número 1: ");
            int num7 = int.Parse(Console.ReadLine());
            mayor7 = num7;
            menor7 = num7;
            suma7 += num7;
            contador7++;
            while (contador7 <= n7)
            {
                Console.Write("Ingrese el número " + contador7 + ": ");
                num7 = int.Parse(Console.ReadLine());
                if (num7 > mayor7) mayor7 = num7;
                if (num7 < menor7) menor7 = num7;
                suma7 += num7;
                contador7++;
            }
            double promedio7 = suma7 / n7;
            Console.WriteLine("El mayor es: " + mayor7);
            Console.WriteLine("El menor es: " + menor7);
            Console.WriteLine("El promedio es: " + promedio7);

            /*8*/
            Console.Write("Ingrese la cantidad de notas: ");
            int n8 = int.Parse(Console.ReadLine());
            int contador8 = 1;
            double sumaPonderada8 = 0;
            double sumaPesos8 = 0;
            while (contador8 <= n8)
            {
                Console.Write("Ingrese la nota " + contador8 + ": ");
                double nota8 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el peso de la nota " + contador8 + ": ");
                double peso8 = double.Parse(Console.ReadLine());
                sumaPonderada8 += nota8 * peso8;
                sumaPesos8 += peso8;
                contador8++;
            }
            double promedioPonderado8 = sumaPonderada8 / sumaPesos8;
            Console.WriteLine("El promedio ponderado es: " + promedioPonderado8);

            /*9*/
            int i9 = 1;
            Console.WriteLine("Tabla de sumar del 1 al 20:\n");
            while (i9 <= 20)
            {
                int j9 = 1;
                while (j9 <= 20)
                {
                    Console.Write(i9 + " + " + j9 + " = " + (i9 + j9) + "\t");
                    j9++;
                }
                Console.WriteLine();
                i9++;
            }

            /*10*/
            Console.Write("Ingrese un número n: ");
            int n10 = int.Parse(Console.ReadLine());
            int i10 = 1;
            while (i10 <= n10)
            {
                int j10 = 1;
                while (j10 <= i10)
                {
                    Console.Write(i10);
                    j10++;
                }
                Console.WriteLine();
                i10++;
            }

            /*11*/
            Console.Write("Ingrese el valor de n (total de dígitos): ");
            int n11 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de r (cifras a formar): ");
            int r11 = int.Parse(Console.ReadLine());
            int factN11 = 1, factR11 = 1, factNR11 = 1;
            int i11 = 1;
            while (i11 <= n11)
            {
                factN11 *= i11;
                i11++;
            }
            i11 = 1;
            while (i11 <= r11)
            {
                factR11 *= i11;
                i11++;
            }
            i11 = 1;
            while (i11 <= (n11 - r11))
            {
                factNR11 *= i11;
                i11++;
            }
            int combinaciones11 = factN11 / (factR11 * factNR11);
            Console.WriteLine("La cantidad de números diferentes que se pueden formar es: " + combinaciones11);

            /*12*/
            Console.Write("Ingrese la cantidad de términos de Fibonacci a mostrar: ");
            int n12 = int.Parse(Console.ReadLine());
            int a12 = 0, b12 = 1, contador12 = 1;
            Console.WriteLine("Secuencia de Fibonacci:");
            while (contador12 <= n12)
            {
                Console.Write(a12 + " ");
                int temp12 = a12 + b12;
                a12 = b12;
                b12 = temp12;
                contador12++;
            }
            Console.WriteLine("\n");
            double razon12 = (double)b12 / a12;
            double aureo12 = (1 + 5) / 2;
            Console.WriteLine("Razón entre los últimos dos términos: " + razon12);
            Console.WriteLine("Número áureo ( (1+ 5)/2 ): " + aureo12);
            Console.WriteLine("La razón se aproxima al número áureo.");
        }
    }
}

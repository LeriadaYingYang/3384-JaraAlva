using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividadsemanal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Determinar el monto a pagar si la tienda da descuentos y regalos según el monto de compras. Si la compra está entre 1000 - 1500 soles, se realiza un descuento del 5% y se le regala una cartuchera. Si la compra es mayor a 1500 soles, se realiza un descuento del 10 % y se le regala un USB de 4 GB. El programa debe mostrar como salidas el monto de la compra y el regalo.*/

            Console.Write("Ingrese el monto de la compra: ");
            double compra = double.Parse(Console.ReadLine());
            double descuento = 0;
            string regalo = "Ninguno";

            if (compra >= 1000 && compra <= 1500)
            {
                descuento = compra * 0.05;
                regalo = "Cartuchera";
            }
            else if (compra > 1500)
            {
                descuento = compra * 0.10;
                regalo = "USB de 4GB";
            }

            double total = compra - descuento;
            Console.WriteLine("Monto a pagar: S/." + total);
            Console.WriteLine("Regalo: " + regalo);

            /*2. En la venta de lápices, hay tres precios, por unidad, por docena y por ciento. El precio por unidad es S/.1, el precio por docena es S/.10 y el precio por ciento es de S/.70. Pedir el número de lápices a comprar y calcular el monto a pagar.*/

            Console.Write("Ingrese la cantidad de lápices a comprar: ");
            int cantidad = int.Parse(Console.ReadLine());
            double total1 = 0;

            if (cantidad >= 100)
                total1 = (cantidad / 100) * 70 + (cantidad % 100 / 12) * 10 + (cantidad % 12);
            else if (cantidad >= 12)
                total1 = (cantidad / 12) * 10 + (cantidad % 12);
            else
                total1 = cantidad * 1;

            Console.WriteLine("Monto a pagar: S/." + total1);

            /*3. Un programa que lea n números enteros y muestre cuántos son impares y positivos.*/

            Console.Write("Ingrese la cantidad de números: ");
            int n = int.Parse(Console.ReadLine());
            int impares = 0, positivos = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 != 0) impares++;
                if (num > 0) positivos++;
            }

            Console.WriteLine("Cantidad de impares: " + impares);
            Console.WriteLine("Cantidad de positivos: " + positivos);

            /*4. Un programa que pida las notas de n alumnos y muestre: el promedio grupal, el número de aprobados y desaprobados, así como el mayor y el menor puntaje obtenido.*/

            Console.Write("Ingrese la cantidad de alumnos: ");
            int n1 = int.Parse(Console.ReadLine());
            int aprobados = 0, desaprobados = 0;
            double suma1 = 0;
            int mayor = int.MinValue, menor = int.MaxValue;

            for (int i1 = 0; i1 < n1; i1++)
            {
                Console.Write("Nota del alumno " + (i1 + 1) + ": ");
                int nota = int.Parse(Console.ReadLine());
                suma1 += nota;

                if (nota >= 11) aprobados++;
                else desaprobados++;

                if (nota > mayor) mayor = nota;
                if (nota < menor) menor = nota;
            }

            double promedio = suma1 / n1;
            Console.WriteLine("Promedio grupal: " + promedio);
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
            Console.WriteLine("Mayor nota: " + mayor);
            Console.WriteLine("Menor nota: " + menor);


        }
    }
}

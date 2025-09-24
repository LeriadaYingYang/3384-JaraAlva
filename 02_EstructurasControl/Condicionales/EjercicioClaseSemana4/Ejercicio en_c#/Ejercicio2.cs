using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Condicionales
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("--Algoritmos con Estructuras de Control Basicas--");
			/* calcular el IGV cuando el monto de venta sea superior a 999 */
			//Declarar variables
			// Primera Forma 
			double impuesto;
			//segunda forma
			double igv = 0.18;// compra
			Console.WriteLine("Ingrese el valor de la Venta: ");
			var monto = double.Parse(Console.ReadLine());

			if (monto > 999)
			{
				//Calculo del IGV
				impuesto = (monto * igv);
				Console.WriteLine($"La venta de {monto} soles genera: {impuesto} soles de IGV");
			}

			Console.WriteLine("Condicional Doble");
			/*De caso anterior si la venta es menor mostrar solo 1% dscto*/
			if (monto > 999)
			{
				//Calculo del IGV
				impuesto = (monto * igv);
				Console.WriteLine($"La venta de {monto} soles genera: {impuesto} soles de IGV");
			}
			else
			{
				var dscto = monto * 0.99;
				Console.WriteLine($"se obtuvo un descuento del 1% y pagara solamente: {dscto} soles");
			}
			Console.WriteLine("Condicional Anidado");
			/*Un niño dislexico quiere saber que vocal es al indicar un numero (1-5)*/
			Console.WriteLine("Ingrese un numero del 1 al 5: ");
			var num = int.Parse(Console.ReadLine());
			if (num == 1)
			{
				Console.WriteLine("La vocal es A");
			}
			else if (num == 2)
			{
				Console.WriteLine("La vocal es E");
			}
			else if (num == 3)
			{
				Console.WriteLine("La vocal es I");
			}
			else if (num == 4)
			{
				Console.WriteLine("La vocal es O");
			}
			else if (num == 5)
			{
				Console.WriteLine("La vocal es U");
			}
			else
			{
				Console.WriteLine("El numero ingresado no es valido");
			}
		}
	}
}

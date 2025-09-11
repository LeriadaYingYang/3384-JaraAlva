//Dar la suma, el producto y el promedio de tres números.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el Primer numero: "); double primer = double.Parse(Console.ReadLine());
Console.Write("Ingrese el Segundo numero: "); double segundo= double.Parse(Console.ReadLine());
Console.Write("Ingrese el Tercer numero: "); double tercer= double.Parse(Console.ReadLine());
double suma = primer+segundo+tercer;
double producto = primer*segundo*tercer;
double promedio = (suma)/3;
Console.WriteLine("El resultado de la suma es: "+ suma);
Console.WriteLine("El resultado del producto es: "+ producto);
Console.WriteLine("El resultado del promedio es: "+ promedio);
    }
}

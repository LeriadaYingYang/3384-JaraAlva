//Hallar la hipotenusa de un triángulo rectángulo.

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer lado (cateto A): ");
double a = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo lado (cateto B): ");
double b = double.Parse(Console.ReadLine());
double r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
Console.WriteLine("El resultado de la hipotenusa es: " + r);
    }
}

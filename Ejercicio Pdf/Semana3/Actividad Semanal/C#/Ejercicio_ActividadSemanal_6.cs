//Hallar las raíces cuadráticas.

class Program
{
    static void Main()
    {
	Console.Write("Ingrese el valor de a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - 4 * a * c;

        double lado1 = (-b + Math.Sqrt(d)) / (2 * a);
        double lado2 = (-b - Math.Sqrt(d)) / (2 * a);

        Console.WriteLine("La primera raíz es: " + lado1);
        Console.WriteLine("La segunda raíz es: " + lado2);
    }
}

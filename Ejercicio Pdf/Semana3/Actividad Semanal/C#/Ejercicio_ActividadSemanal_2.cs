//Hallar el volumen del cilindro.

class Program
{
    static void Main()
    {
	Console.Write("Ingrese el radio");
	double radio = double.Parse(Console.ReadLine());
	Console.Write("Ingrese la alatura del cilindro");
	double altura = double.Parse(Console.ReadLine());
	double volumen = Math.PI * (Math.Pow(radio, 2)) * altura ;
	Console.WriteLine("El volumen del cilindro es : "+ volumen);
    }
}

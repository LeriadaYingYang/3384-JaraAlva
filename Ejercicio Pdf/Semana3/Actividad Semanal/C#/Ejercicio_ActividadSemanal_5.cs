//Hallar el área y el volumen de un paralelepípedo.

class Program
{
    static void Main()
    {
	Console.Write("Ingrese el lado de largo");
	double largo= double.Parse(Console.ReadLine());
	Console.Write("Ingrese el ancho");
	double ancho= double.Parse(Console.ReadLine());
	Console.Write("Ingrese el alto");
	double alto= double.Parse(Console.ReadLine());

	double area = 2*((largo*ancho)+(largo*alto)+(ancho*alto));
	double volumen = (largo* ancho * alto);

	Console.WriteLine("El area es de : "+ area );
	Console.WriteLine("El volumen es de : "+ volumen);
    }
}

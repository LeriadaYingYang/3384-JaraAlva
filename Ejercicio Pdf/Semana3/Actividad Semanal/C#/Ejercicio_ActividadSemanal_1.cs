//Calcular el área y el perímetro de un terreno rectangular.

class Program
{
    static void Main()
    {
	Console.Write("Ingrese la Base del terreno rectangular");
	double baserec = double.Parse(Console.Readline());
	Console.Write("Ingrese la altura del terreno rectangular");
	double altura= double.Parse(Console.Readline());
	double area = baserec * altura;
	double perimetro = 2*(baserec + altura);
	Console.WriteLine("El Area del terreno rectangular es de: "+ area);
	Console.WriteLine("El perimetro del terreno rectangular es de: "+ perimetro);
    }
}

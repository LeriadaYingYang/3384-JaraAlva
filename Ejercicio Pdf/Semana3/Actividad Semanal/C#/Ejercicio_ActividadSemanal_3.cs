//Calcular el equivalente de metros en pulgadas.

class Program
{
    static void Main()
    {
	Console.Write("Ingrese los metros que quiere convertir a Pulgadas");
	double metro = double.Parse(Console.ReadLine());
	double pulgadas= metro * 39.3701 ;
	Console.WriteLine("El Resultado en pulgadas es de : "+ pulgadas);
    }
}

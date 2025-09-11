//Hallar el costo total a pagar por estacionamiento si el monto por hora cuesta S/. 2.5.

class Program
{
    static void Main()
    {
	Console.Write("Ingrese las horas estacionadas del cliente");
	double horas = double.Parse(Console.ReadLine());
	double monto = horas * 2.50 ;
	Console.WriteLine("El monto a pagar es de: s/. "+ monto);
    }
}

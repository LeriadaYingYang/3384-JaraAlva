//Hallar el promedio ponderado, si nota 1(20%), nota 2(30%), nota 3(40%) y nota 4(10%).

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la nota 1 (20%): ");double nota1 = double.Parse(Console.ReadLine());
double t1 = nota1 * 0.20;

Console.Write("Ingrese la nota 2 (30%): ");double nota2 = double.Parse(Console.ReadLine());
double t2 = nota2 * 0.30;

Console.Write("Ingrese la nota 3 (40%): ");double nota3 = double.Parse(Console.ReadLine());
double t3 = nota3 * 0.40;

Console.Write("Ingrese la nota 4 (10%): ");double nota4 = double.Parse(Console.ReadLine());
double t4 = nota4 * 0.10;

double resultado = t1 + t2 + t3 + t4;
Console.WriteLine("Su nota ponderada es de: " + resultado);

    }
}

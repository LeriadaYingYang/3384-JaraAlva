using System;

namespace TallerCsharp
{
    public class Ejercicio1
    {
        public void areatriangulo()
        {
            // Solicitar y leer los lados del triángulo
            Console.WriteLine("Ingrese lado a: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado b: ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado c: ");
            var c = int.Parse(Console.ReadLine());

            // Calcular semiperímetro
            var s = (a + b + c) / 2.0;

            // Calcular área usando la fórmula de Herón
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Mostrar resultado
            Console.WriteLine($"El área del triángulo con lados {a}, {b}, {c} es: {area} m²");

            // Detener pantalla
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

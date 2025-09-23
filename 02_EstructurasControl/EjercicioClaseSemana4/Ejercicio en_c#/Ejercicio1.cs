using System;

namespace TallerCsharp
{
    public class Ejercicio1
    {
        public void areatriangulo()
        {
            // Solicitar y leer los lados del tri�ngulo
            Console.WriteLine("Ingrese lado a: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado b: ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese lado c: ");
            var c = int.Parse(Console.ReadLine());

            // Calcular semiper�metro
            var s = (a + b + c) / 2.0;

            // Calcular �rea usando la f�rmula de Her�n
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Mostrar resultado
            Console.WriteLine($"El �rea del tri�ngulo con lados {a}, {b}, {c} es: {area} m�");

            // Detener pantalla
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

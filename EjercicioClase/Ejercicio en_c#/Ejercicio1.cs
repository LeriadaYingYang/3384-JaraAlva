using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp
{
    public class Ejercicio1
    {
        public void areatriangulo() {

            //Definir Variables
            //double area;
            //float s;

            //Solicitar Datos
            Console.WriteLine("Ingrese lado a: ");
            //Guardar datos
            var a= int.Parse(Console.ReadLine());
            //Solicitar Datos
            Console.WriteLine("Ingrese lado b: ");
            //Guardar datos
            var b = int.Parse(Console.ReadLine());
            //Solicitar Datos
            Console.WriteLine("Ingrese lado c: ");
            //Guardar datos
            var c = int.Parse(Console.ReadLine());

            //Proceso
            //s = (a + b + c) / 2; //s = semiperimetro
            var s = (a + b + c) / 2; //s = semiperimetro
            //area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Salida Datos
            Console.WriteLine($"El Area del Triangulo segun lados {a},{b},{c} es: {area} m2");       
          
            //Detener pantalla para ver resultados
            Console.ReadKey();
        }
    }
}
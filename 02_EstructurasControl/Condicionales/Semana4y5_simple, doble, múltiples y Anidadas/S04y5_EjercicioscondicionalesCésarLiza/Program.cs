using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_EjercicioscondicionalesCésarLiza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EjercicioPropuesto*/
            // 1. Vocales con números del 1 al 5
            Console.Write("Ingrese un número del 1 al 5: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 1) Console.WriteLine("Es la vocal A");
            else if (num == 2) Console.WriteLine("Es la vocal E");
            else if (num == 3) Console.WriteLine("Es la vocal I");
            else if (num == 4) Console.WriteLine("Es la vocal O");
            else if (num == 5) Console.WriteLine("Es la vocal U");
            else Console.WriteLine("Número inválido");

            // 2. Día de la semana
            Console.Write("Ingrese un número del 1 al 7 (domingo=1): ");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Domingo"); break;
                case 2: Console.WriteLine("Lunes"); break;
                case 3: Console.WriteLine("Martes"); break;
                case 4: Console.WriteLine("Miércoles"); break;
                case 5: Console.WriteLine("Jueves"); break;
                case 6: Console.WriteLine("Viernes"); break;
                case 7: Console.WriteLine("Sábado"); break;
                default: Console.WriteLine("Número inválido"); break;
            }

            // 3. Calificación de alumno
            Console.Write("Ingrese calificación (a, b, c o d): ");
            char cal = char.Parse(Console.ReadLine());
            if (cal == 'a') Console.WriteLine("Alumno bueno");
            else if (cal == 'b') Console.WriteLine("Alumno regular");
            else if (cal == 'c') Console.WriteLine("Alumno malo");
            else if (cal == 'd') Console.WriteLine("Alumno pésimo");
            else Console.WriteLine("Calificación inválida");

            // 4. Mes del año
            Console.Write("Ingrese un número del 1 al 12: ");
            int mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1: Console.WriteLine("Enero"); break;
                case 2: Console.WriteLine("Febrero"); break;
                case 3: Console.WriteLine("Marzo"); break;
                case 4: Console.WriteLine("Abril"); break;
                case 5: Console.WriteLine("Mayo"); break;
                case 6: Console.WriteLine("Junio"); break;
                case 7: Console.WriteLine("Julio"); break;
                case 8: Console.WriteLine("Agosto"); break;
                case 9: Console.WriteLine("Septiembre"); break;
                case 10: Console.WriteLine("Octubre"); break;
                case 11: Console.WriteLine("Noviembre"); break;
                case 12: Console.WriteLine("Diciembre"); break;
                default: Console.WriteLine("Número inválido"); break;
            }

            // 5. Fecha de ayer
            Console.Write("Ingrese una fecha (yyyy-mm-dd): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("La fecha de ayer fue: " + fecha.AddDays(-1).ToShortDateString());

            // 6. Canales de TV
            Console.Write("Ingrese un número de canal (2, 4, 5, 7, 9, 13): ");
            int canal = int.Parse(Console.ReadLine());
            switch (canal)
            {
                case 2: Console.WriteLine("América TV"); break;
                case 4: Console.WriteLine("Latina"); break;
                case 5: Console.WriteLine("Panamericana"); break;
                case 7: Console.WriteLine("TV Perú"); break;
                case 9: Console.WriteLine("ATV"); break;
                case 13: Console.WriteLine("Global TV"); break;
                default: Console.WriteLine("Canal desconocido"); break;
            }

            // 7. Menú de opciones
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Opción A");
            Console.WriteLine("2. Opción B");
            Console.WriteLine("3. Opción C");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Console.WriteLine("Ha seleccionado la opción A"); break;
                case 2: Console.WriteLine("Ha seleccionado la opción B"); break;
                case 3: Console.WriteLine("Ha seleccionado la opción C"); break;
                default: Console.WriteLine("Opción inválida"); break;

            }
            //8. Empresa de 3 categorias

            Console.Write("Cliente (E/B/R/M): ");
            string c = Console.ReadLine().Trim().ToUpper();
            Console.Write("Artículo (A/B/C): ");
            string a = Console.ReadLine().Trim().ToUpper();
            int desc = 0;
            string pago;
            switch (c)
            {
                case "E":
                    pago = "Efectivo, Cheque o Crédito";
                    switch (a)
                    {
                        case "A": desc = 40; break;
                        case "B": desc = 30; break;
                        case "C": desc = 20; break;
                        default: Console.WriteLine("Artículo inválido"); return;
                    }
                    break;
                case "B":
                    pago = "Efectivo, Cheque o Crédito";
                    switch (a)
                    {
                        case "A": desc = 30; break;
                        case "B": desc = 20; break;
                        case "C": desc = 10; break;
                        default: Console.WriteLine("Artículo inválido"); return;
                    }
                    break;
                case "R":
                    pago = "Efectivo o Cheque";
                    switch (a)
                    {
                        case "A": desc = 20; break;
                        case "B": desc = 10; break;
                        case "C": desc = 0; break;
                        default: Console.WriteLine("Artículo inválido"); return;
                    }
                    break;
                case "M":
                    pago = "Solo Efectivo";
                    if (a == "A" || a == "B" || a == "C") desc = 0;
                    else { Console.WriteLine("Artículo inválido"); return; }
                    break;

                default:
                    Console.WriteLine("Cliente inválido");
                    return;
            }
            Console.WriteLine($"Descuento: {desc}% | Pagos permitidos: {pago}");

            //10. Obtenga el número de días transcurridos entre dos fechas.

            Console.Write("Ingrese la primera fecha (yyyy-mm-dd): ");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda fecha (yyyy-mm-dd): ");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());
            TimeSpan diasTranscurridos = fechaFin - fechaInicio;
            Console.WriteLine($"Han transcurrido {Math.Abs(diasTranscurridos.Days)} días entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}.");

            //11. Todo el mundo sabe cuántos años tiene, pero ¿podría contestar a la pregunta cuántos días tiene?
            Console.Write("Ingrese su edad en años: ");
            int edad = int.Parse(Console.ReadLine());
            int diasVida = edad * 365; 
            Console.WriteLine($"Usted ha vivido aproximadamente {diasVida} días.");

        }
    }
}
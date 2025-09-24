using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Calcule la longitud de una circunferencia de radio conocido.*/
            double radio, longitud;
            Console.WriteLine("Ingrese el radio de la circunferencia:"); radio = Convert.ToDouble(Console.ReadLine());
            longitud = 2 * Math.PI * radio;
            Console.WriteLine("La longitud de la circunferencia es: " + longitud);

            /*2.Calcule el área de un trapecio cuyas base menor, base mayor y altura son conocidas.*/
            double baseMenor, baseMayor, altura, area;
            Console.WriteLine("Ingrese la base menor del trapecio:"); baseMenor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la base mayor del trapecio:"); baseMayor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del trapecio:"); altura = Convert.ToDouble(Console.ReadLine());
            area = ((baseMenor + baseMayor) / 2) * altura;
            Console.WriteLine("El área del trapecio es: " + area);

            /*3. Sabiendo que una milla equivale a 1.609 kilómetros, lea una cantidad en millas y conviértala a kilómetros.*/
            double millas, kilometros;
            Console.WriteLine("Ingrese la cantidad en millas:"); millas = Convert.ToDouble(Console.ReadLine());
            kilometros = millas * 1.609;
            Console.WriteLine("La cantidad en kilómetros es: " + kilometros);

            /*4. Calcule el perímetro de un rectángulo.*/
            double ladoA, ladoB, perimetro;
            Console.WriteLine("Ingrese el lado A del rectángulo:"); ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado B del rectángulo:"); ladoB = Convert.ToDouble(Console.ReadLine());
            perimetro = 2 * (ladoA + ladoB);
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

            /*5. Calcule el perímetro de un triángulo rectángulo si se conocen sus catetos.*/
            double catetoA, catetoB, hipotenusa, perimetroTriangulo;
            Console.WriteLine("Ingrese el cateto A del triángulo rectángulo:"); catetoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el cateto B del triángulo rectángulo:"); catetoB = Convert.ToDouble(Console.ReadLine());
            hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
            perimetroTriangulo = catetoA + catetoB + hipotenusa;
            Console.WriteLine("El perímetro del triángulo rectángulo es: " + perimetroTriangulo);

            /*6. ¿Cuál es el volumen de un paralelepípedo de largo, ancho y altura conocidos?*/
            double largo, ancho, alturaParalelepipedo, volumen;
            Console.WriteLine("Ingrese el largo del paralelepípedo:"); largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho del paralelepípedo:"); ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del paralelepípedo:"); alturaParalelepipedo = Convert.ToDouble(Console.ReadLine());
            volumen = largo * ancho * alturaParalelepipedo;
            Console.WriteLine("El volumen del paralelepípedo es: " + volumen);

            /*7. ¿Cuál es el área total de un paralelepípedo?*/
            double areaTotal;
            areaTotal = 2 * (largo * ancho + largo * alturaParalelepipedo + ancho * alturaParalelepipedo);
            Console.WriteLine("El área total del paralelepípedo es: " + areaTotal);

            /*8. Calcule el área de un triángulo cuando se conocen dos lados y el ángulo que forman.*/
            double lado1, lado2, angulo, areaTriangulo;
            Console.WriteLine("Ingrese el lado 1 del triángulo:"); lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2 del triángulo:"); lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el ángulo entre los dos lados (en grados):"); angulo = Convert.ToDouble(Console.ReadLine());
            areaTriangulo = (lado1 * lado2 * Math.Sin(angulo * Math.PI / 180)) / 2;
            Console.WriteLine("El área del triángulo es: " + areaTriangulo);

            /*9. En todo triangulo se cumple que cada lado es proporcional al seno del angulo opuesto.*/
            /*10. En un campeonato de fútbol participan n equipos. ¿Cuántos partidos habrá en la primera rueda del campeonato?*/
            Console.WriteLine("Ingrese la cantidad de equipos participantes:"); int n = Convert.ToInt32(Console.ReadLine());
            int partidos = (n * (n - 1)) / 2;
            Console.WriteLine("La cantidad de partidos en la primera rueda del campeonato es: " + partidos);

            /*11. Calcule la suma de los n primeros números pares.*/
            Console.WriteLine("Ingrese la cantidad de números pares a sumar:"); int m = Convert.ToInt32(Console.ReadLine());
            int sumaPares = m * (m + 1);
            Console.WriteLine("La suma de los " + m + " primeros números pares es: " + sumaPares);

            /*12. Calcule la siguiente suma: s = 1×2 + 2×3 + 3×4 + ... + n×(n + 1).*/
            Console.WriteLine("Ingrese el valor de n para calcular la suma s = 1×2 + 2×3 + ... + n×(n + 1):"); int p = Convert.ToInt32(Console.ReadLine());
            int suma = (p * (p + 1) * (p + 2)) / 3;
            Console.WriteLine("La suma s es: " + suma);

            /*13. Calcule la siguiente suma: s = 1 + 3 + 5 + 7 + ... + (2n − 1).*/
            Console.WriteLine("Ingrese el valor de n para calcular la suma s = 1 + 3 + 5 + ... + (2n - 1):"); int q = Convert.ToInt32(Console.ReadLine());
            int sumaImpares = q * q;
            Console.WriteLine("La suma s es: " + sumaImpares);

            /*14. Lea una temperatura en grados Kelvin y conviértela a grados Celsius, Fahrenheit y Rankine.*/
            double kelvin, celsius, fahrenheit, rankine;
            Console.WriteLine("Ingrese la temperatura en grados Kelvin:"); kelvin = Convert.ToDouble(Console.ReadLine());
            celsius = kelvin - 273.15;
            fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
            rankine = kelvin * 9 / 5;
            Console.WriteLine("La temperatura en grados Celsius es: " + celsius);
            Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);
            Console.WriteLine("La temperatura en grados Rankine es: " + rankine);

            /*15. Lea tres temperaturas, una en grados Celsius, otra en grados Kelvin y otra en grados Rankine, y conviértelas a grados Fahrenheit.*/

            double celsius2, kelvin2, rankine2, fahrenheitFromCelsius, fahrenheitFromKelvin, fahrenheitFromRankine;
            Console.WriteLine("Ingrese la temperatura en grados Celsius:"); celsius2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura en grados Kelvin:"); kelvin2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura en grados Rankine:"); rankine2 = Convert.ToDouble(Console.ReadLine());

            fahrenheitFromCelsius = (celsius2 * 9 / 5) + 32;
            fahrenheitFromKelvin = (kelvin2 - 273.15) * 9 / 5 + 32;
            fahrenheitFromRankine = rankine2 - 459.67;

            Console.WriteLine("Fahrenheit desde Celsius: " + fahrenheitFromCelsius);
            Console.WriteLine("Fahrenheit desde Kelvin: " + fahrenheitFromKelvin);
            Console.WriteLine("Fahrenheit desde Rankine: " + fahrenheitFromRankine);

            /*16. Lea una hora y diga a cuántas horas, minutos y segundos equivale.*/
            Console.WriteLine("Ingrese una hora en formato decimal (por ejemplo, 2.5 para 2 horas y 30 minutos):"); double horaDecimal = Convert.ToDouble(Console.ReadLine());
            int horas = (int)horaDecimal;
            int minutos = (int)((horaDecimal - horas) * 60);
            int segundos = (int)((((horaDecimal - horas) * 60) - minutos) * 60);
            Console.WriteLine("Equivale a: " + horas + " horas, " + minutos + " minutos y " + segundos + " segundos.");

            /*17 Lea un ángulo en radianes y conviértalo a grados, minutos y segundos sexagesimales.*/
            Console.WriteLine("Ingrese un ángulo en radianes:"); double radianes = Convert.ToDouble(Console.ReadLine());
            double gradosDecimal = radianes * (180.0 / Math.PI);
            int gradosEnteros = (int)gradosDecimal;
            int minutosEnteros = (int)((gradosDecimal - gradosEnteros) * 60);
            int segundosEnteros = (int)((((gradosDecimal - gradosEnteros) * 60) - minutosEnteros) * 60);
            Console.WriteLine("El ángulo es: " + gradosEnteros + " grados, " + minutosEnteros + " minutos y " + segundosEnteros + " segundos.");

            /*18 Convierta el ángulo centesimal XgYmZs a grados sexagesimales.*/
            int gradosCentesimales, minutosCentesimales, segundosCentesimales;
            Console.WriteLine("Ingrese los grados centesimales:"); gradosCentesimales = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos centesimales:"); minutosCentesimales = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos centesimales:"); segundosCentesimales = Convert.ToInt32(Console.ReadLine());
            double gradosSexagesimales = gradosCentesimales * 0.9 + minutosCentesimales * 0.9 / 100 + segundosCentesimales * 0.9 / 10000;
            Console.WriteLine("El ángulo en grados sexagesimales es: " + gradosSexagesimales);

            /*19. Lea dos números. El primero representará el día y mes de su nacimiento (por ejemplo, 1 de julio será 107). El segundo número vendrá dado por su edad. Luego, realice los siguientes cálculos: multiplique el primer número por 2, adiciónale 5, multiplíquelo por 50, súmele el segundo número, súmele 365 y réstele 615. El resultado será la unión del primer número con el segundo. Este juego es conocido en los círculos matemáticos como juego de sociedad.*/
            int nacimiento, edad;
            Console.WriteLine("Ingrese el día y mes de su nacimiento (por ejemplo, 1 de julio será 107):"); nacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad:"); edad = Convert.ToInt32(Console.ReadLine());
            int resultado = (((((nacimiento * 2) + 5) * 50) + edad + 365) - 615);
            Console.WriteLine("El resultado es: " + resultado);

            /*20. En un cuadrado cuyo lado es a se unen los puntos medios de sus cuatro lados. Se forma así otro cuadrado cuyos puntos medios se unen también formando otro cuadrado, y así sucesivamente. Calcule la suma de los perímetros de todos los cuadrados así formados.*/
            double ladoCuadrado, sumaPerimetros = 0;
            Console.WriteLine("Ingrese el lado del cuadrado inicial:"); ladoCuadrado = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                double perimetroCuadrado = 4 * ladoCuadrado;
                sumaPerimetros += perimetroCuadrado;
                ladoCuadrado /= Math.Sqrt(2);
            }
            Console.WriteLine("La suma de los perímetros de todos los cuadrados es: " + sumaPerimetros);

            /*21. ¿A cuánto dinero de hoy (e) equivalen m dólares del futuro sabiendo que la tasa de interés es t y el número de periodos es n? Recuerde que: m = c(1 + t)^n.*/

            double mFuturo, tasa, periodos, presente;
            Console.WriteLine("Ingrese m (dólares del futuro):"); mFuturo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese t (tasa, ej. 0.05):"); tasa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese n (n° de periodos):"); periodos = Convert.ToDouble(Console.ReadLine());
            presente = mFuturo / Math.Pow(1 + tasa, periodos);
            Console.WriteLine("Dinero de hoy (e): " + presente);

            /*22. Un inversionista está pensando invertir C dólares a una tasa de interés T. ¿Cuántos periodos (N) necesita para tener al final M dólares?*/

            double capital, tasas, montoFinal, N;
            Console.WriteLine("Ingrese C (capital):"); capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese T (tasa, ej. 0.05):"); tasas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese M (monto objetivo):"); montoFinal = Convert.ToDouble(Console.ReadLine());
            N = Math.Log(montoFinal / capital) / Math.Log(1 + tasas);
            Console.WriteLine("Número de periodos (N): " + N);

            /*23. ¿Cuántos billetes de 5, 10, 20, 50 y 100 nuevos soles y monedas de 0,01, 0,05, 0,1, 0,5 y 1 nuevo sol recibirá un empleado como pago por su trabajo? Suponga que se le debe entregar la máxima cantidad posible de billetes y monedas de cada denominación.*/
            Console.Write("Ingrese el monto a pagar (S/): ");
            double monto = double.Parse(Console.ReadLine());

            int centimos = (int)Math.Round(monto * 100);

            int b100 = centimos / 10000; centimos %= 10000;
            int b50 = centimos / 5000; centimos %= 5000;
            int b20 = centimos / 2000; centimos %= 2000;
            int b10 = centimos / 1000; centimos %= 1000;
            int b5 = centimos / 500; centimos %= 500;

            int m1 = centimos / 100; centimos %= 100;
            int m050 = centimos / 50; centimos %= 50;
            int m010 = centimos / 10; centimos %= 10;
            int m005 = centimos / 5; centimos %= 5;
            int m001 = centimos / 1; centimos %= 1;

            Console.WriteLine("\nDescomposición:");
            Console.WriteLine("Billetes de 100: " + b100);
            Console.WriteLine("Billetes de 50 : " + b50);
            Console.WriteLine("Billetes de 20 : " + b20);
            Console.WriteLine("Billetes de 10 : " + b10);
            Console.WriteLine("Billetes de 5  : " + b5);
            Console.WriteLine("Monedas de 1   : " + m1);
            Console.WriteLine("Monedas de 0.5 : " + m050);
            Console.WriteLine("Monedas de 0.1 : " + m010);
            Console.WriteLine("Monedas de 0.05: " + m005);
            Console.WriteLine("Monedas de 0.01: " + m001);

            /*24. Calcule la media aritmética de los n primeros números enteros positivos.*/
            Console.WriteLine("Ingrese la cantidad de números enteros positivos para calcular la media aritmética:"); int r = Convert.ToInt32(Console.ReadLine());
            double mediaAritmetica = (r + 1) / 2.0;
            Console.WriteLine("La media aritmética de los " + r + " primeros números enteros positivos es: " + mediaAritmetica);

            Console.ReadKey();

        }
    }
}

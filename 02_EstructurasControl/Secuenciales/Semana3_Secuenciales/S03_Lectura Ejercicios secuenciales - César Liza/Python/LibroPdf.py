import math
#1 Calcule la longitud de una circunferencia de radio conocido.

r = float(input("Radio: "))
L = 2 * math.pi * r
print(f"Longitud de la circunferencia = {L}")


#2 Calcule el área de un trapecio cuyas base menor, base mayor y altura son conocidas.

b_menor = float(input("Base menor: "))
b_mayor = float(input("Base mayor: "))
h = float(input("Altura: "))
A = (b_menor + b_mayor) / 2 * h
print(f"Área del trapecio = {A}")


#3 Sabiendo que una milla equivale a 1.609 kilómetros, lea una cantidad en millas y conviértala a kilómetros.

millas = float(input("Millas: "))
km = millas * 1.609
print(f"Kilómetros = {km}")

#4 Calcule el perímetro de un rectángulo.

largo = float(input("Largo: "))
ancho = float(input("Ancho: "))
P = 2 * (largo + ancho)
print(f"Perímetro del rectángulo = {P}")


#5 Calcule el perímetro de un triángulo rectángulo si se conocen sus catetos.

a = float(input("Cateto a: "))
b = float(input("Cateto b: "))
c = math.sqrt(a*a + b*b)  # hipotenusa
perimetro = a + b + c
print(f"Perímetro del triángulo rectángulo = {perimetro}")


#6 ¿Cuál es el volumen de un paralelepípedo de largo, ancho y altura conocidos?

largo = float(input("Largo: "))
ancho = float(input("Ancho: "))
alto = float(input("Alto: "))
V = largo * ancho * alto
print(f"Volumen = {V}")


#7 ¿Cuál es el área total de un paralelepípedo?

largo = float(input("Largo: "))
ancho = float(input("Ancho: "))
alto = float(input("Alto: "))
area_total = 2 * (largo*ancho + largo*alto + ancho*alto)
print(f"Área total = {area_total}")


#8 Calcule el área de un triángulo cuando se conocen dos lados y el ángulo que forman.

lado1 = float(input("Lado 1: "))
lado2 = float(input("Lado 2: "))
angulo_deg = float(input("Ángulo entre ellos (grados): "))
A = 0.5 * lado1 * lado2 * math.sin(math.radians(angulo_deg))
print(f"Área del triángulo = {A}")

#9 En todo triángulo se cumple que cada lado es proporcional al seno del ángulo opuesto.
#10 En un campeonato de fútbol participan n equipos. ¿Cuántos partidos habrá en la primera rueda del campeonato?

n = int(input("Número de equipos: "))
partidos = n * (n - 1) // 2
print("Número de partidos:", partidos)

#11 Calcule la suma de los n primeros números pares.

n = int(input("Valor de n: "))
suma = n * (n + 1)
print("La suma de los", n, "primeros pares es:", suma)

#12 Calcule la siguiente suma: s = 1×2 + 2×3 + 3×4 + ... + n×(n + 1).

n = int(input("Valor de n: "))
suma = 0
for i in range(1, n+1):
    suma += i * (i + 1)
print("Resultado de la suma:", suma)

#13 Calcule la siguiente suma: s = 1 + 3 + 5 + 7 + ... + (2n ? 1).

n = int(input("Valor de n: "))
suma = n * n
print("Resultado de la suma:", suma)

#14 Lea una temperatura en grados Kelvin y conviértela a grados Celsius, Fahrenheit y Rankine.

K = float(input("Temperatura en Kelvin: "))
C = K - 273.15
F = (K - 273.15) * 9/5 + 32
R = K * 9/5
print("Celsius:", C)
print("Fahrenheit:", F)
print("Rankine:", R)

#15 Lea tres temperaturas, una en grados Celsius, otra en grados Kelvin y otra en grados Rankine, y conviértalas a grados Fahrenheit.

C = float(input("Temperatura en Celsius: "))
K = float(input("Temperatura en Kelvin: "))
R = float(input("Temperatura en Rankine: "))

F1 = C * 9/5 + 32
F2 = (K - 273.15) * 9/5 + 32
F3 = R - 459.67

print("Celsius a Fahrenheit:", F1)
print("Kelvin a Fahrenheit:", F2)
print("Rankine a Fahrenheit:", F3)

#16 Lea una hora y diga a cuántas horas, minutos y segundos equivale.

h = float(input("Horas: "))
print("Horas:", h)
print("Minutos:", h*60)
print("Segundos:", h*3600)

#17 Lea un ángulo en radianes y conviértalo a grados, minutos y segundos sexagesimales.

r = float(input("Ángulo en radianes: "))
g = r*180/math.pi
grado = int(g)
minuto_total = (g - grado)*60
minuto = int(minuto_total)
segundo = (minuto_total - minuto)*60
print("Grados:", grado, "Minutos:", minuto, "Segundos:", segundo)

#18 Convierta el ángulo centesimal XgYmZs a grados sexagesimales.

X = float(input("Grados centesimales (g): "))
Y = float(input("Minutos centesimales (m): "))
Z = float(input("Segundos centesimales (s): "))
g_sexa = 0.9*(X + Y/100 + Z/10000)
G = int(g_sexa)
M_total = (g_sexa - G)*60
M = int(M_total)
S = (M_total - M)*60
print("Grados:", G, "Minutos:", M, "Segundos:", S)


#19 Lea dos números (día/mes de nacimiento y edad) y realice el “juego de sociedad”.

d = int(input("Día (1-31): "))
m = int(input("Mes (1-12): "))
edad = int(input("Edad: "))
p = d*100 + m
p = p*2
p = p + 5
p = p*50
p = p + edad
p = p + 365
p = p - 615
print("Resultado:", p)

#20 En un cuadrado, uniendo puntos medios sucesivamente, calcule la suma de los perímetros de los cuadrados formados.

a = float(input("Lado del primer cuadrado: "))
suma_perimetros = 4*a / (1 - 1/(2**0.5))
print("Suma de perímetros:", suma_perimetros)

#21 ¿A cuánto dinero de hoy (e) equivalen m dólares del futuro sabiendo que la tasa de interés es t y el número de periodos es n?

m = float(input("Monto futuro m: "))
t = float(input("Tasa por periodo t: "))
n = float(input("Número de periodos n: "))
c = m / ((1 + t)**n)
print("Valor presente c:", c)


#22 Un inversionista invierte C dólares a tasa T. ¿Cuántos periodos (N) necesita para tener M dólares?

C = float(input("Capital inicial C: "))
T = float(input("Tasa por periodo T: "))
M = float(input("Monto objetivo M: "))
N = math.log(M/C) / math.log(1 + T)
print("Número de periodos N:", N)

#23 ¿Cuántos billetes de 5, 10, 20, 50 y 100 y monedas de 0,01; 0,05; 0,10; 0,50 y 1 recibirá por un monto dado (máxima cantidad por denominación)?

monto = float(input("Ingrese el monto en soles: "))

centimos = int(round(monto * 100))

b100 = centimos // 10000
centimos = centimos % 10000

b50 = centimos // 5000
centimos = centimos % 5000

b20 = centimos // 2000
centimos = centimos % 2000

b10 = centimos // 1000
centimos = centimos % 1000

b5 = centimos // 500
centimos = centimos % 500

m1 = centimos // 100
centimos = centimos % 100

m050 = centimos // 50
centimos = centimos % 50

m010 = centimos // 10
centimos = centimos % 10

m005 = centimos // 5
centimos = centimos % 5

m001 = centimos // 1
centimos = centimos % 1

print("Billetes de 100:", b100)
print("Billetes de 50:", b50)
print("Billetes de 20:", b20)
print("Billetes de 10:", b10)
print("Billetes de 5:", b5)
print("Monedas de 1:", m1)
print("Monedas de 0.50:", m050)
print("Monedas de 0.10:", m010)
print("Monedas de 0.05:", m005)
print("Monedas de 0.01:", m001)

#24 Calcule la media aritmética de los n primeros números enteros positivos.

n = int(input("n: "))
media = (n + 1) / 2
print("Media aritmética:", media)

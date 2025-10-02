import math

# /*1*/
x = int(input("Ingrese el valor de x: "))
y = int(input("Ingrese el valor de y: "))

contador = 0
if x % 2 != 0:
    x += 1

print("Números pares entre los valores ingresados:")
while x <= y:
    print(x)
    contador += 1
    x += 2
print("Cantidad de números pares:", contador)

# /*2*/
inicio = int(input("Ingrese el límite inferior del rango: "))
fin = int(input("Ingrese el límite superior del rango: "))

print("Números perfectos en el rango dado:")
num = inicio
while num <= fin:
    suma_div = 0
    d = 1
    while d < num:
        if num % d == 0:
            suma_div += d
        d += 1
    if suma_div == num and num != 0:
        print(num)
    num += 1

# /*3*/
print("Números primos de tres dígitos:")
num3 = 100
while num3 <= 999:
    divisor3 = 2
    es_primo3 = True
    while divisor3 <= num3 // 2:
        if num3 % divisor3 == 0:
            es_primo3 = False
            break
        divisor3 += 1
    if es_primo3:
        print(num3)
    num3 += 1

# /*4*/
print("Números Armstrong (cubos perfectos):")
num4 = 0
fin4 = 999
while num4 <= fin4:
    temp4 = num4
    suma_cubos4 = 0
    while temp4 > 0:
        dig4 = temp4 % 10
        suma_cubos4 += dig4 * dig4 * dig4
        temp4 //= 10
    if suma_cubos4 == num4:
        print(num4)
    num4 += 1

# /*5*/
n5 = int(input("Ingrese el valor de n: "))
print("Pares de números amigos menores que", n5, ":")
a5 = 2
while a5 < n5:
    sumaA5 = 0
    i5 = 1
    while i5 < a5:
        if a5 % i5 == 0:
            sumaA5 += i5
        i5 += 1
    b5 = sumaA5
    if b5 > a5 and b5 < n5:
        sumaB5 = 0
        j5 = 1
        while j5 < b5:
            if b5 % j5 == 0:
                sumaB5 += j5
            j5 += 1
        if sumaB5 == a5:
            print(a5, "y", b5)
    a5 += 1

# /*6*/
inicio6 = int(input("Ingrese el límite inferior del rango: "))
fin6 = int(input("Ingrese el límite superior del rango: "))
print("Números capicúas en el rango dado:")
num6 = inicio6
while num6 <= fin6:
    original6 = num6
    invertido6 = 0
    t6 = num6
    while t6 > 0:
        d6 = t6 % 10
        invertido6 = invertido6 * 10 + d6
        t6 //= 10
    if original6 == invertido6:
        print(num6)
    num6 += 1

# /*7*/
n7 = int(input("Ingrese la cantidad de números: "))
contador7 = 1
suma7 = 0.0

num7 = int(input("Ingrese el número 1: "))
mayor7 = num7
menor7 = num7
suma7 += num7
contador7 += 1

while contador7 <= n7:
    num7 = int(input(f"Ingrese el número {contador7}: "))
    if num7 > mayor7:
        mayor7 = num7
    if num7 < menor7:
        menor7 = num7
    suma7 += num7
    contador7 += 1

promedio7 = suma7 / n7
print("El mayor es:", mayor7)
print("El menor es:", menor7)
print("El promedio es:", promedio7)

# /*8*/
n8 = int(input("Ingrese la cantidad de notas: "))
contador8 = 1
suma_pond8 = 0.0
suma_pesos8 = 0.0
while contador8 <= n8:
    nota8 = float(input(f"Ingrese la nota {contador8}: "))
    peso8 = float(input(f"Ingrese el peso de la nota {contador8}: "))
    suma_pond8 += nota8 * peso8
    suma_pesos8 += peso8
    contador8 += 1
prom_pond8 = suma_pond8 / suma_pesos8
print("El promedio ponderado es:", prom_pond8)

# /*9*/
print("Tabla de sumar del 1 al 20:\n")
i9 = 1
while i9 <= 20:
    j9 = 1
    fila = []
    while j9 <= 20:
        fila.append(f"{i9} + {j9} = {i9 + j9}")
        j9 += 1
    print("\t".join(fila))
    i9 += 1

# /*10*/
n10 = int(input("Ingrese un número n: "))
i10 = 1
while i10 <= n10:
    j10 = 1
    linea = []
    while j10 <= i10:
        linea.append(str(i10))
        j10 += 1
    print("".join(linea))
    i10 += 1

# /*11*/
n11 = int(input("Ingrese el valor de n (total de dígitos): "))
r11 = int(input("Ingrese el valor de r (cifras a formar): "))

factN11 = 1
i11 = 1
while i11 <= n11:
    factN11 *= i11
    i11 += 1

factR11 = 1
i11 = 1
while i11 <= r11:
    factR11 *= i11
    i11 += 1

factNR11 = 1
i11 = 1
while i11 <= (n11 - r11):
    factNR11 *= i11
    i11 += 1

combinaciones11 = factN11 // (factR11 * factNR11)
print("La cantidad de números diferentes que se pueden formar es:", combinaciones11)

# /*12*/
n12 = int(input("Ingrese la cantidad de términos de Fibonacci a mostrar: "))
a12, b12, contador12 = 0, 1, 1
print("Secuencia de Fibonacci:")
linea = []
while contador12 <= n12:
    linea.append(str(a12))
    t12 = a12 + b12
    a12 = b12
    b12 = t12
    contador12 += 1
print(" ".join(linea))
print()

razon12 = b12 / a12 if a12 != 0 else float('inf')
aureo12 = (1 + math.sqrt(5)) / 2
print("Razón entre los últimos dos términos:", razon12)
print("Número áureo ( (1+√5)/2 ):", aureo12)
print("La razón se aproxima al número áureo.")

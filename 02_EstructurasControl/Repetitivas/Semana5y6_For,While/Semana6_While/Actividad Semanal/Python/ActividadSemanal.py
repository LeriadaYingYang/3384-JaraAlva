#1. Encontrar la suma de n números ingresados por el teclado.

n = int(input("Ingrese la cantidad de números: "))
suma = 0
i = 1

while i <= n:
    num = int(input(f"Ingrese el número {i}: "))
    suma += num
    i += 1

print("La suma es:", suma)

#2. Encontrar la suma de n números aleatorios.

import random

n2 = int(input("Ingrese la cantidad de números aleatorios: "))
suma2 = 0
i2 = 1

while i2 <= n2:
    num2 = random.randint(1, 100)
    print(f"Número {i2}: {num2}")
    suma2 += num2
    i2 += 1

print("La suma de los números aleatorios es:", suma2)

#3. Diseñar un programa que calcule el promedio de las notas ingresadas por consola. Cuando el usuario ingrese una nota igual a cero o negativa se dejarán de ingresar las notas.

suma3 = 0
contador3 = 0

print("Ingrese las notas (0 o negativas para terminar):")
nota3 = int(input("Nota: "))

while nota3 > 0:
    suma3 += nota3
    contador3 += 1
    nota3 = int(input("Nota: "))

if contador3 > 0:
    promedio3 = suma3 / contador3
    print("Promedio de notas:", promedio3)
else:
    print("No se ingresaron notas válidas.")




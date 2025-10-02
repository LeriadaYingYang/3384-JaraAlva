# 1. 
num1 = int(input("Ingrese un número: "))
i1 = 1
factorial1 = 1

while True:
    factorial1 *= i1
    i1 += 1
    if i1 > num1:
        break

print(f"El factorial de {num1} es: {factorial1}")


# 2. 
a2 = int(input("Ingrese el valor de a: "))
b2 = int(input("Ingrese el valor de b: "))

print(f"Números pares entre {a2} y {b2}:")
i2 = a2
while True:
    if i2 % 2 == 0:
        print(i2)
    i2 += 1
    if i2 > b2:
        break


# 3.
n3 = int(input("¿Cuántos números desea ingresar?: "))

num3 = int(input("Ingrese el número 1: "))
mayor3 = num3
menor3 = num3
suma3 = num3

i3 = 2
while True:
    if i3 > n3:
        break
    num3 = int(input(f"Ingrese el número {i3}: "))

    if num3 > mayor3:
        mayor3 = num3

    if num3 < menor3:
        menor3 = num3

    suma3 += num3
    i3 += 1

promedio3 = suma3 / n3

print("Mayor:", mayor3)
print("Menor:", menor3)
print("Promedio:", promedio3)

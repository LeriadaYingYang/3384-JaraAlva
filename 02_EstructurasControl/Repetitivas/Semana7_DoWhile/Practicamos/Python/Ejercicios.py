# 1.
n = int(input("¿Cuántos números desea ingresar?: "))
i = 1
suma = 0
producto = 1

while True:
    print("Ingrese el número", i, end=": ")
    num = int(input())
    suma += num
    producto *= num
    i += 1
    if i > n:
        break

promedio = suma / n
print("Suma:", suma)
print("Producto:", producto)
print("Promedio:", promedio)


# 2.
n2 = int(input("¿Cuántos números desea ingresar?: "))
i2 = 1

print("Ingrese el número 1: ", end="")
num2 = int(input())
mayor2 = num2

i2 = 2
while True:
    if i2 > n2:
        break
    print("Ingrese el número", i2, end=": ")
    num2 = int(input())
    if num2 > mayor2:
        mayor2 = num2
    i2 += 1

print("El mayor número es:", mayor2)


# 3.
n3 = int(input("¿Cuántos términos de Fibonacci desea mostrar?: "))
a3, b3 = 1, 1
i3 = 3

print("Serie de Fibonacci:", a3, b3, end="")

while True:
    if i3 > n3:
        break
    c3 = a3 + b3
    print("", c3, end="")
    a3 = b3
    b3 = c3
    i3 += 1

print()


# 4.
opcion4 = 0
a4 = 0
b4 = 0

while True:
    print("\nMENÚ:")
    print("[1] Leer números A y B")
    print("[2] Suma")
    print("[3] Producto")
    print("[4] División")
    print("[5] Salir")
    opcion4 = int(input("Elija una opción: "))

    if opcion4 == 1:
        a4 = float(input("Ingrese A: "))
        b4 = float(input("Ingrese B: "))
    elif opcion4 == 2:
        print("Suma:", a4 + b4)
    elif opcion4 == 3:
        print("Producto:", a4 * b4)
    elif opcion4 == 4:
        if b4 != 0:
            print("División:", a4 / b4)
        else:
            print("No se puede dividir entre cero.")
    elif opcion4 == 5:
        break

print("Programa finalizado.")

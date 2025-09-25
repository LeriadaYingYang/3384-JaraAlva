# Programa que pida un número entero n y calcule la suma de los primeros n números naturales.
n = int(input("Ingrese un número: "))
suma = 0

for i in range(1, n + 1):
    suma += i   # equivalente a suma = suma + i

print("La suma de los primeros", n, "números es:", suma)

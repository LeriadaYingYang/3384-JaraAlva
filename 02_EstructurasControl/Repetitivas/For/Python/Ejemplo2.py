# Programa que pida un n�mero entero n y calcule la suma de los primeros n n�meros naturales.
n = int(input("Ingrese un n�mero: "))
suma = 0

for i in range(1, n + 1):
    suma += i   # equivalente a suma = suma + i

print("La suma de los primeros", n, "n�meros es:", suma)

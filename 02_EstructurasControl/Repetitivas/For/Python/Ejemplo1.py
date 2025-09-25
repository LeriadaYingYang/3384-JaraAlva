# calcula la suma de los cuadrados de los primeros n números enteros.

n = int(input("Número de elementos: "))
suma = 0

for i in range(1, n + 1):
    suma = suma + i * i

print("Suma:", suma)

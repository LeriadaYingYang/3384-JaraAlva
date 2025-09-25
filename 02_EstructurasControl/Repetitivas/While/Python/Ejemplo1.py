# solicita al usuario un número entero n, que representa la cantidad de elementos a usar. Luego, mediante un ciclo while, calcula la suma de los n primeros números impares.

def sumar(n):
    impar = 1
    suma = 0
    while n > 0:
        suma = suma + impar
        impar = impar + 2
        n = n - 1
    print("La suma es:", suma)

n = int(input("Número de elementos a usar: "))
sumar(n)

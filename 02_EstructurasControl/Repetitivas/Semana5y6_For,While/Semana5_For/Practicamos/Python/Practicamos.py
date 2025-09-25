# 1. Programa que presente la tabla de multiplicar

n = int(input("Ingrese el número de la tabla: "))

print(f"Tabla de multiplicar del {n}")

for i in range(1, 13):
    print(f"{n} x {i} = {n * i}")

# 2. Programa que imprima * 

for i in range(1, 7):
    print("*" * i)


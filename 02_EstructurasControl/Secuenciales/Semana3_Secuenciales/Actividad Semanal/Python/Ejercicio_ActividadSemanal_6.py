# Hallar las raíces cuadráticas.

a = float(input("Ingrese a: "))
b = float(input("Ingrese b: "))
c = float(input("Ingrese c: "))

discriminante = (b**2 - 4*a*c) ** 0.5

x1 = (-b + discriminante) / (2*a)
x2 = (-b - discriminante) / (2*a)

print("Raíz 1:", x1)
print("Raíz 2:", x2)
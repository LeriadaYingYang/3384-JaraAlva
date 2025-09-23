""" Elabore un algoritmo que resuelva las raices reales cuadraticas """
a = float(input("Ingrese el valor de a: "))
b = float(input("Ingrese el valor de b: "))
c = float(input("Ingrese el valor de c: "))
d = b**2 - 4*a*c
if d < 0:
    print("No existen raíces reales")
elif d == 0:
    x = -b / (2*a)
    print(f"Existe una raíz real: x = {x}")
else:
    x1 = (-b + d**0.5) / (2*a)
    x2 = (-b - d**0.5) / (2*a)
    print(f"Existen dos raíces reales: x1 = {x1} y x2 = {x2}")
#�C�mo calcular el �rea de un tri�ngulo en base a sus 3 lados?

la = int(input("Ingrese lado A: "))
lb = int(input("Ingrese lado B: "))
lc = int(input("Ingrese lado C: "))

s = (la + lb + lc) / 2

area = (s * (s - la) * (s - lb) * (s - lc)) ** 0.5

print("El �rea es:", area)
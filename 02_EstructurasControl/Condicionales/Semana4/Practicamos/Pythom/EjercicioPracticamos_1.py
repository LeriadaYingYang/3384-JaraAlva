""" Encuentre el mayor valor de tres números dados """
a = int(input("Ingrese el primer número: "))
b = int(input("Ingrese el segundo número: "))
c = int(input("Ingrese el tercer número: "))
if a >= b and a >= c:
	mayor = a
elif b >= a and b >= c:
	mayor = b
else:
	mayor = c
print("El mayor valor es:", mayor)
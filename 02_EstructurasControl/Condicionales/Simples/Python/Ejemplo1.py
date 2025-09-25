# Leer 2 números a y b, en el caso de que a sea mayor que b intercambiar sus valores, de lo contrario no hacer nada.
a = int(input("Ingrese el valor de a: "))
b = int(input("Ingrese el valor de b: "))
if a > b:
	a, b = b, a
print("a:", a, "b:", b)

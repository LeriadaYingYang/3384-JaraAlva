""" Leer 2 numeros a y b, en el caso de que a sea mayor que b intercambiar
sus valores, de lo contrario no incrementar sus valores en 1 """
a = int(input("Ingrese el valor de a: "))
b = int(input("Ingrese el valor de b: "))
if a > b:
    a, b = b, a
    print(f"Sus valores son: {a}, {b}")
else:
    a += 1
    b += 1
    print(f"Los valores finales son a: {a} y b: {b}")

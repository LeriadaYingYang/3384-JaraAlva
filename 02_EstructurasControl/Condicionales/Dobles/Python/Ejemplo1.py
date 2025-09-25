# Leer 2 números a y b, en el caso de que a sea menor que b intercambiar sus valores, de lo contrario incrementar sus valores en 1.

a = int(input("Ingrese el valor de a: "))
b = int(input("Ingrese el valor de b: "))

if a < b:
    temp = a
    a = b
    b = temp
else:
    a = a + 1
    b = b + 1

print("Nuevo valor de a:", a)
print("Nuevo valor de b:", b)

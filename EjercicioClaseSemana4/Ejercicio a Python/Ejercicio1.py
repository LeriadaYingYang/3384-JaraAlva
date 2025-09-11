a=int(input("Ingrese lado a: "))
b=int(input("Ingrese lado b: "))
c=int(input("Ingrese lado c: "))
s=(a+b+c)/2
area=(s*(s-a)*(s-b)*(s-c))**0.5
print(f"El Area del Triangulo segun lados {a},{b},{c} es: {area} m2")

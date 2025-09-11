#Calcular el área y el perímetro de un terreno rectangular.

print("Calcular el área y el perímetro de un terreno rectangular.")
area = 0
perimetro = 0

base = float(input("Ingrese la base del terreno rectangular: "))
altura = float(input("Ingrese la altura del terreno rectangular: "))
area = base * altura
perimetro = 2 * (base + altura)
print("El área del terreno rectangular es: ", area)
print("El perímetro del terreno rectangular es: ", perimetro)



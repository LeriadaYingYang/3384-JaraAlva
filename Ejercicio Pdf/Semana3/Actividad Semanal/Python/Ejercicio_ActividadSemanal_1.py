#Calcular el area y el perimetro de un terreno rectangular.

print("Calcular el area y el perimetro de un terreno rectangular.")
area = 0
perimetro = 0

base = float(input("Ingrese la base del terreno rectangular: "))
altura = float(input("Ingrese la altura del terreno rectangular: "))
area = base * altura
perimetro = 2 * (base + altura)
print("El area del terreno rectangular es: ", area)
print("El perimetro del terreno rectangular es: ", perimetro)




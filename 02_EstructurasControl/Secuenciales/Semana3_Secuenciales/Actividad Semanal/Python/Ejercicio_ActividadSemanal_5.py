# Hallar el �rea y el volumen de un paralelep�pedo.

largo = float(input("Ingrese el largo: "))
ancho = float(input("Ingrese el ancho: "))
alto = float(input("Ingrese el alto: "))

area = 2 * (largo * ancho + largo * alto + ancho * alto)
volumen = largo * ancho * alto

print("El �rea:", area)
print("El Volumen:", volumen)

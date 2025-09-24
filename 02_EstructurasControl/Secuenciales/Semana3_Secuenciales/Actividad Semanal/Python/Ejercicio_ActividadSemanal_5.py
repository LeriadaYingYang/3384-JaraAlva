# Hallar el área y el volumen de un paralelepípedo.

largo = float(input("Ingrese el largo: "))
ancho = float(input("Ingrese el ancho: "))
alto = float(input("Ingrese el alto: "))

area = 2 * (largo * ancho + largo * alto + ancho * alto)
volumen = largo * ancho * alto

print("El Área:", area)
print("El Volumen:", volumen)

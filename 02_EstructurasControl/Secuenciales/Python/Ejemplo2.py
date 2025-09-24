# Qué pasaría si me piden calcular el volumen del tronco de un cono ¿cómo lo resuelvo?

r1 = float(input("Ingrese el radio mayor (r1): "))
r2 = float(input("Ingrese el radio menor (r2): "))
h = float(input("Ingrese la altura (h): "))

S1 = 3.1416 * (r1 ** 2)
S2 = 3.1416 * (r2 ** 2)

volumen = (h / 3) * (S1 + S2 + (S1 * S2) ** 0.5)

print("El volumen del tronco de cono es:", volumen)
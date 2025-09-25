nota = int(input("Ingrese la nota (0-20): "))

if 0 <= nota <= 10:
    print("Desaprobado")
elif 11 <= nota <= 15:
    print("Regular")
elif 16 <= nota <= 20:
    print("Excelente")
else:
    print("Nota fuera de rango")
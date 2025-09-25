# Genera un número secreto entre 1 y 20 y usa un while para que el usuario lo adivine, contando los intentos hasta acertar.

import random

secreto = random.randint(1, 20)
intentos = 0
adivinado = False

print("Adivina el número (entre 1 y 20):")

while not adivinado:
    numero = int(input("Ingresa tu intento: "))
    intentos += 1

    if numero == secreto:
        print("¡Correcto! Adivinaste en", intentos, "intentos.")
        adivinado = True
    elif numero < secreto:
        print("El número es mayor.")
    else:
        print("El número es menor.")
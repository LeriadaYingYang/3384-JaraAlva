"""Generar un número aleatorio entre 1 y 5, y de acuerdo con el número
obtenido indicar qué premio obtuvo:
• <1> 0 soles
• <2> 5 soles
• <3> 10 soles
• <4> 20 soles
• <5> 50 soles"""
import random
numero_aleatorio = random.randint(1, 5)
if numero_aleatorio == 1:
    premio = "0 soles"
elif numero_aleatorio == 2:
    premio = "5 soles"
elif numero_aleatorio == 3:
    premio = "10 soles"
elif numero_aleatorio == 4:
    premio = "20 soles"
else:
    premio = "50 soles"
    print(f"El número aleatorio es: {numero_aleatorio}, y el premio obtenido es: {premio}")
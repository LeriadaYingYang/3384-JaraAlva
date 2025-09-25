""" Dado un numero, si es menor que cero, hallar su valor absoluto, de lo contrario, mostrar la raiz cuadrada. """
num = float(input("Ingrese un número: "))
if num < 0:
    print(f"El valor absoluto de {num} es {abs(num)}")
else:
    print(f"La raíz cuadrada de {num} es {num**0.5}")
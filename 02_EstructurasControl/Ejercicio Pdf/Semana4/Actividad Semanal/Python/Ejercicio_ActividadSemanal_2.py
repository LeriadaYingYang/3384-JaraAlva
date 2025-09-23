"""Elaborar un programa que verifique si un número es impar y múltiplo de 5"""
numero = int(input("Ingrese un número: "))
if numero % 2 != 0 and numero % 5 == 0:
    print(f"El número {numero} es impar y múltiplo de 5.")
else:
    print(f"El número {numero} no cumple con las condiciones.")
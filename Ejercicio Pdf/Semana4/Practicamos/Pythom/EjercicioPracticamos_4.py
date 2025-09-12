""" Dado un n�mero que var�e en el rango de 1 a 12, mostrar el nombre del
mes al que representa e indicar el numero de dias de este. """
n = int(input("Ingrese un número del 1 al 12: "))
if n == 1:
    print("Enero, 31 días")
elif n == 2:
    print("Febrero, 28 días (29 en año bisiesto)")
elif n == 3:
    print("Marzo, 31 días")
elif n == 4:
    print("Abril, 30 días")
elif n == 5:
    print("Mayo, 31 días")
elif n == 6:
    print("Junio, 30 días")
elif n == 7:
    print("Julio, 31 días")
elif n == 8:
    print("Agosto, 31 días")
elif n == 9:
    print("Septiembre, 30 días")
elif n == 10:
    print("Octubre, 31 días")
elif n == 11:
    print("Noviembre, 30 días")
elif n == 12:
    print("Diciembre, 31 días")
else:
    print("Número inválido. Por favor ingrese un número del 1 al 12.")
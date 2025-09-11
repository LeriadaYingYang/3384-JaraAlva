# calcular el IGV cuando el monto de venta sea superior a 999
monto_venta = float(input("Ingrese el valor de venta: "))
if monto_venta > 999:
	igv = monto_venta * 0.18
	print(f"El IGV para un monto de venta de {monto_venta} soles genera: {igv} soles de IGV")
else:
	dscto = monto_venta * 0.99
	print("No se aplica IGV para montos de venta menores o iguales a 999")
#Un ni�o dislexico quiere saber que vocal es al indicar un numero (1-5)
num = int(input("Ingrese un numero del 1 al 5: "))
if num == 1:
	print("La vocal es A")
elif num == 2:
	print("La vocal es E")
elif num == 3:
	print("La vocal es I")
elif num == 4:
	print("La vocal es O")
elif num == 5:
	print("La vocal es U")
else:
	print("El numero ingresado no esta en el rango de 1 a 5")


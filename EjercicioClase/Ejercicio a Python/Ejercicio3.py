#aca si funciona
print("Menu de Opciones")
print("1. Algoritmo secuencias")
print("2. Algoritmo condicionales simple")
print("3. Algoritmo condicionales doble")
print("4. Algoritmo condicionales anidado")
opcion = int(input("Seleccione una opcion: "))
if opcion == 1:
    print("Algoritmo Secuencial")
    costo = 2
    km = int(input("Ingrese Km de viaje: "))
    costotransporte = costo * km
    print(f"El pago por el viaje de {km} Km es: {costotransporte} soles")
elif opcion == 2:
    print("Algoritmo Condicional Simple")
    monto_venta = float(input("Ingrese el valor de venta: "))
    if monto_venta > 999:
        igv = monto_venta * 0.18
        print(f"El IGV para un monto de venta de {monto_venta} soles genera: {igv} soles de IGV")
    else:
        dscto = monto_venta * 0.99
        print("No se aplica IGV para montos de venta menores o iguales a 999")
elif opcion == 3:
            print("Algoritmo Condicional Doble")
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
elif opcion == 4:
            print("Algoritmo Condicional Anidado")
            nota = int(input("Ingrese la calificación: "))

            if 0 <= nota <= 100:
                if nota >= 90:
                    print("Aprobado con A")
                elif nota >= 80:
                    print("Aprobado con B")
                elif nota >= 70:
                    print("Aprobado con C")
                else:
                    print("Reprobado")
else:
    print("Opcion no valida")


                   
# 1. Determinar el monto a pagar si la tienda da descuentos y regalos según el monto de compras. Si la compra está entre 1000 - 1500 soles, se realiza un descuento del 5% y se le regala una cartuchera. Si la compra es mayor a 1500 soles, se realiza un descuento del 10 % y se le regala un USB de 4 GB. El programa debe mostrar como salidas el monto de la compra y el regalo.*/

compra = float(input("Ingrese el monto de la compra: "))
descuento = 0
regalo = "Ninguno"

if 1000 <= compra <= 1500:
    descuento = compra * 0.05
    regalo = "Cartuchera"
elif compra > 1500:
    descuento = compra * 0.10
    regalo = "USB de 4GB"

total = compra - descuento
print("Monto a pagar: S/.", total)
print("Regalo:", regalo)

# 2. En la venta de lápices, hay tres precios, por unidad, por docena y por ciento. El precio por unidad es S/.1, el precio por docena es S/.10 y el precio por ciento es de S/.70. Pedir el número de lápices a comprar y calcular el monto a pagar.*/

cantidad = int(input("Ingrese la cantidad de lápices a comprar: "))
total1 = 0

if cantidad >= 100:
    total1 = (cantidad // 100) * 70 + (cantidad % 100 // 12) * 10 + (cantidad % 12) * 1
elif cantidad >= 12:
    total1 = (cantidad // 12) * 10 + (cantidad % 12) * 1
else:
    total1 = cantidad * 1

print("Monto a pagar: S/.", total1)

# 3. Un programa que lea n números enteros y muestre cuántos son impares y positivos.*/

n = int(input("Ingrese la cantidad de números: "))
impares = 0
positivos = 0

for i in range(n):
    num = int(input(f"Número {i+1}: "))
    if num % 2 != 0:
        impares += 1
    if num > 0:
        positivos += 1

print("Cantidad de impares:", impares)
print("Cantidad de positivos:", positivos)


# 4. Un programa que pida las notas de n alumnos y muestre: el promedio grupal, el número de aprobados y desaprobados, así como el mayor y el menor puntaje obtenido.*/

n = int(input("Ingrese la cantidad de alumnos: "))
aprobados = 0
desaprobados = 0
suma1 = 0
mayor = -9999
menor = 9999

for i1 in range(n):
    nota = int(input(f"Nota del alumno {i1+1}: "))
    suma1 += nota

    if nota >= 11:
        aprobados += 1
    else:
        desaprobados += 1

    if nota > mayor:
        mayor = nota
    if nota < menor:
        menor = nota

promedio = suma1 / n
print("Promedio grupal:", promedio)
print("Aprobados:", aprobados)
print("Desaprobados:", desaprobados)
print("Mayor nota:", mayor)
print("Menor nota:", menor)
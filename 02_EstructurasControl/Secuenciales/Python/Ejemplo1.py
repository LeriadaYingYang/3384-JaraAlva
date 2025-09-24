#Cálculo de sueldo con descuento de impuestos con 8% de impuesto

sueldo_base = float(input("Ingrese el sueldo base: "))

descuento = sueldo_base * 0.08
sueldo_neto = sueldo_base - descuento

print("El descuento aplicado es:", descuento)
print("El sueldo neto es:", sueldo_neto)
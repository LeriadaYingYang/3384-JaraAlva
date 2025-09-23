# Hallar el sueldo neto de un trabajador en base al sueldo base, sabiendo que se le descuenta por AFP 10% del sueldo neto y 5% de seguro de vida. Además, se le considera un bono extra de 85 soles por escolaridad.
sueldo_base = float(input("Ingrese el sueldo base: "))
bono_escolaridad = 85.0
descuento_afp = 0.10
descuento_seguro_vida = 0.05
sueldo_neto = sueldo_base + bono_escolaridad - (sueldo_base * descuento_afp) - (sueldo_base * descuento_seguro_vida)
print("El sueldo neto del trabajador es: S/.", sueldo_neto)



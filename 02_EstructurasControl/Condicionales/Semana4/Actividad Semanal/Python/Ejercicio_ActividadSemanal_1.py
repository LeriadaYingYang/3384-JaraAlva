"""Elaborar un programa que calcule el impuesto de la renta apagar (5%), solo si su monto de renta supera las 7 UITS"""
uit = 5250.00
impuesto = 0.05
renta = float(input("Ingrese el monto de su renta anual: "))
if renta > 7 * uit:
    monto_impuesto = renta * impuesto
    print(f"El monto del impuesto a pagar es: S/ {monto_impuesto:.2f}")
else:
    print("No paga impuesto de la renta.")

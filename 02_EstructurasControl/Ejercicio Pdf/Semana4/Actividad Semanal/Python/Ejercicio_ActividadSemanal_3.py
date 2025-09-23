"""Calcular el pago a recibir en base a las horas trabajadas y la
tarifa ingresada. Si existen horas extra al jornal semanal
máximo (40 horas) deberá considerar un pago extra del 15%
por la diferencia de horas"""
horas = int(input("Ingrese las horas trabajadas: "))
tarifa = float(input("Ingrese la tarifa por hora: "))
if horas > 40:
    horas_extra = horas - 40
    pago = (40 * tarifa) + (horas_extra * tarifa * 1.15)
else:
    pago = horas * tarifa
    print(f"El pago a recibir es:",pago)
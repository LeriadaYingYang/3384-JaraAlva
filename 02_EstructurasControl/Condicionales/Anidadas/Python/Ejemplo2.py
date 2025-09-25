#En el proceso de admisión de una universidad pública, el costo de inscripción es de
#240 soles, en la tabla se muestra el monto que deberá ser agregado a la inscripción.
#Si un postulante es hijo de un trabajador de la universidad no paga inscripción.
#Elaborar un programa que pida el tipo de colegio, lugar de nacimiento y si es hijo de
#trabajador universitario; luego de ello calcular el monto a pagar.

costo_inscripcion = 240
monto_extra = 0

trabajador = input("¿Es hijo de trabajador universitario? (si/no): ").lower()

if trabajador == "si":
    print("Monto a pagar: 0")
else:
    colegio = input("Tipo de colegio (estatal/particular): ").lower()
    lugar = input("Lugar de nacimiento (cajamarca/provincia/otra): ").lower()

    if lugar == "cajamarca":
        if colegio == "estatal":
            monto_extra = 0
        else:
            monto_extra = 30
    elif lugar == "provincia":
        if colegio == "estatal":
            monto_extra = 20
        else:
            monto_extra = 50
    else:  # otra provincia
        if colegio == "estatal":
            monto_extra = 100
        else:
            monto_extra = 150

    total = costo_inscripcion + monto_extra
    print("Monto a pagar:", total)
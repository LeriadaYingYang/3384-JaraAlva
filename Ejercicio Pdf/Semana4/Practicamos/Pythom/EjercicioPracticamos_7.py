""" Elaborar un programa que calcule el promedio de 4 notas y muestre aprobados si su promedio es mayor o igual que 12. """
nota1 = float(input("Ingrese la primera nota: "))
nota2 = float(input("Ingrese la segunda nota: "))
nota3 = float(input("Ingrese la tercera nota: "))
nota4 = float(input("Ingrese la cuarta nota: "))
promedio = (nota1 + nota2 + nota3 + nota4) / 4
if promedio >= 12:
    print("Aprobado")
else:
    print("Reprobado")

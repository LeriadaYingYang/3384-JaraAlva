#Cómo podría escribir un algoritmo que lea un carácter y dependiendo del carácter ingresado (‘s’, ‘c’, ‘v’, ‘d’, otro cualquiera) nos imprima:
#            . Soltero
#            . Casado
#            . Viudo
#            . Divorciado
#            . Sin especificar
#            . Plantear alternativas
ec = input("Estado civil (s, c, v, d): ").lower() 

if ec == 's':
    print("Soltero")
elif ec == 'c':
    print("Casado")
elif ec == 'v':
    print("Viudo")
elif ec == 'd':
    print("Divorciado")
else:
    print("Sin especificar")
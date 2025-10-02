n = int(input("Ingrese un número entero: "))

print("Número invertido:", end=" ")

while True:
    digito = n % 10      
    print(digito, end="")  
    n = n // 10       
    if n <= 0:     
        break

print()
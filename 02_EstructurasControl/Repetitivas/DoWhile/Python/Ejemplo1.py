n = int(input("Ingrese un n�mero entero: "))

print("N�mero invertido:", end=" ")

while True:
    digito = n % 10      
    print(digito, end="")  
    n = n // 10       
    if n <= 0:     
        break

print()
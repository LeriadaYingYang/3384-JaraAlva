numero = int(input("N�mero: "))

print("N�mero invertido: ", end="")

while True:
    residuo = numero % 10
    print(residuo, end="")
    numero = numero // 10
    if numero <= 0:
        break

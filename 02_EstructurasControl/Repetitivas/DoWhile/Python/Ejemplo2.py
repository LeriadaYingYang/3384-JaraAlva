numero = int(input("Número: "))

print("Número invertido: ", end="")

while True:
    residuo = numero % 10
    print(residuo, end="")
    numero = numero // 10
    if numero <= 0:
        break

# 1.Hacer que nuestro programa escriba en pantalla 1000 veces el texto “Todos los días reviso dos problemas de algoritmos”
i = 1
while i <= 1000:
    print(f"{i}. Todos los días reviso dos problemas de algoritmos")
    i += 1

# 2.Indicar si un número es perfecto, cuando la suma de sus divisores es igual al número. Por ejemplo 6, tiene como divisores a 1,2 y 3, luego 1+2+3=6.
num2 = int(input("Ingrese un número: "))
suma2 = 0
i2 = 1

while i2 < num2:
    if num2 % i2 == 0:
        suma2 += i2
    i2 += 1

if suma2 == num2:
    print(num2, "es un número perfecto.")
else:
    print(num2, "no es un número perfecto.")
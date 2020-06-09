suma=0
numero=1
while numero<=100:
    numero+=1
    if numero>=20 and numero<=30:
        continue
    if numero%2==0:
        suma+=numero
print("La suma de los número pares entre 1 al 19 y del 31 al 100 es: ")
print(suma)
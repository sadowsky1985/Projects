# def ordenLongitud(elemento):
#     return len(elemento)

nombres = []
nuevo = ""
while nuevo.upper() != "FIN":
    nuevo = input("Escribe un nombre (FIN para acabar): ")
    if nuevo.upper() != "FIN":
        veces = nombres.count(nuevo)
        if veces == 0:
            nombres.append(nuevo)
# Una vez acabada la lista, la ordenamos
nombres.sort()
# La volvemos a ordenar por longitud, los elementos de igual longitud ya quedaron ordenados alfabéticamente.
nombres.sort(key=lambda e:len(e))
print("La lista ordenada es:")
for nombre in nombres:
    print(nombre.ljust(15), end="")
            
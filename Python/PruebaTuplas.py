tarifas = "sencillo", 1500, "doble", 1900

def imprime():
    contador = 0
    while contador < len(tarifas):
        print(tarifas[contador].ljust(10) + str(tarifas[contador + 1]).rjust(5))
        contador +=2

print("tupla original:")
imprime()
# tarifas[3] = 1800 # Provoca error
tarifas = list(tarifas)
tarifas[1] = 1700 # Podemos hacerlo porque es una lista
tarifas = tuple(tarifas)
print("tupla alterada:")
imprime()
# tarifas[3] = 1800 # Provoca un error

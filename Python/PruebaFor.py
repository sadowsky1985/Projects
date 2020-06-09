'''
nombres=["Alejandro", "Merche", "Adela", "Carmelo"]
for nombre in nombres:
    if nombre == "Merche":
        nombre == "Mercedes" # Podemos modificar el valor del elemento
    print(nombre)
print("¡Fin de la lista")
'''
numeros = range(10,0,-1)
print("Esta es la tabla de multiplicar del 5:")
for numero in numeros:
    if numero==5:
        continue
    print("5 x", numero, "=", 5*numero)
print("Eso es todo!")
conjunto = "Italia", "Grecia", "China", "Grecia", "Brasil"
paises = set(conjunto)
europa = set({"Francia", "Italia", "España", "Grecia", "Alemania", "Portugal"})

def listado(conjunto):
    for pais in conjunto:
        print(pais.ljust(15), end="")
        
paises.remove("China")
paises.add("Turquia")
paises.add("Alemania")

print("contenido actual del conjunto de paises:")
listado(paises)

print("\n\ncontenido actual del conjunto de paises de Europa:")
listado(europa)

print("\n\nUnión de los dos conjuntos:")
listado(paises | europa)

print("\n\nIntersección de los dos conjuntos (elementos en común):")
listado(paises.intersection(europa))

print("\n\ndiferencia de los dos conjuntos ( elementos de paises" + " que no están en europa):")
listado(paises.difference(europa))

print("\n\ndiferencia simétrica de los dos conjuntos (elementoos que" + " no están a la vez en ambos conjuntos):")
listado(paises.symmetric_difference(europa))

paises.update(europa)
print("\n\nActualización de paises con el contenido de europa:")
listado(paises)
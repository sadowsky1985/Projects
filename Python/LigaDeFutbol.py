Liga = {"Real Madrid":0, "Barcelona":0, "Valencia":0, "Sevilla":0, "Logroñés":0}

cantidadequipos = 0
totalgoles = 0
maximo = 0
equipomaximo = ""
minimo = 1000
equipominimo = ""

for equipo in Liga.items():
    goles = eval(input("Goles del " + equipo[0] + ": "))
    Liga[equipo[0]] = goles
    cantidadequipos += 1
    totalgoles = totalgoles + goles
    if goles > maximo:
        maximo = goles
        equipomaximo = equipo[0]
    if goles < minimo:
        minimo = goles
        equipominimo = equipo[0]

print("\nPromedio de goles: " + str(totalgoles / cantidadequipos))
print("Equipo con máximo de goles (" + str(maximo) + "): " + equipomaximo)
print("Equipo con mínimo de goles (" + str(minimo) + "): " + equipominimo)
Liga.pop(equipomaximo)
Liga.pop(equipominimo)
print("\nLa liga discriminando al máximo y al mínimo queda:")
print(Liga)
        
        
    
    
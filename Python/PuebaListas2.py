jugadores = []
equipos = []
listado = [jugadores, equipos]
jugador = ""
while jugador.upper() != "FIN":
    jugador = input("Nombre del jugador (FIN para teminar):")
    if jugador.upper() != "FIN":
        equipo = input("Nombre de su equipo: ")
        jugadores.append(jugador)
        equipos.append(equipo)
print("\n\nDATOS INTRODUCIDOS")
print("\n\nCONSULTAS")
equipo = ""
while equipo.upper() != "FIN":
    equipo = input("\nNombre del equipo (FIN para terminar): ")
    if equipo.upper() != "FIN":
        if equipo in equipos: # Si existe...
            print("JUGADORES: ", end="")
            for i in range(len(equipos)):
                if listado[1][i] == equipo:
                    print(listado[0][i].ljust(20), end="")
        else:
            print("\nEquipo no encontrado.")
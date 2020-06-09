jugadores = []
equipos = []
listado = [jugadores, equipos]
jugador = ""
while jugador.upper() != "FIN":
    jugador = input("Escriba nombre del jugador (FIN para finalizar): ")
    if jugador.upper() != "FIN":
        equipo = input("Escriba su equipo: ")
        jugadores.append(jugador)
        equipos.append(equipos)
print("\nDATOS INTRODUCIDOS:")
print("\n\nCONSULTAS:")
equipo = ""
while equipo.upper() != "FIN":
    input("Nombre del equipo (FIN para finalizar): ")
    if equipo.upper() != "FIN":
        if equipo in equipos:
            print("JUGADORES: ", end = "")
            for i in range(len(equipos)):
                if listado[1][i] == equipo:
                    print(listado[0][i].ljust(20), end = "")
                else:
                    print("\nEquipo no encontrado")
        
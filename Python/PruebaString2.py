print("resultado del clásico".upper())
cadena = input("Indique el resultado en formato Equipo1 Goles Equipo2 Goles: ")
espacios = cadena.count(" ") # solo admitiremos 3 espacios
if espacios != 3:
    print("El formato escrito es erróneo!")
else:
    posBarc = cadena.lower().find("barcelona")
    posMadr = cadena.lower().find("madrid")
    if posBarc == -1 or posMadr == -1:
        print("Los equipos no son correctos!")
    else:
        if posBarc < posMadr:
            print("El partido se jugó en el Camp Nou")
        else:
            print("El partido se jugó en el Santiago Bernabeu")
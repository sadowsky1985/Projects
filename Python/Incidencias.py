print("gestión de incidencias".upper().center(80,"-"))
incidencia = input("Indique la incidencia: ")
incidencia.lower()
if incidencia.startswith("error"[:5]):
    if incidencia.find("panel") > - 1:
        numpanel = incidencia.count("panel")
        if numpanel > 1:
            print("Detectado un error en " + str(numpanel) + " paneles")  
        else:
            print("Detectado un error en 1 panel")
else:
    if incidencia.startswith("aviso"[:5]):
        if incidencia.find("conmutador") > - 1:
            if incidencia.endswith("verde"):
                print("Atasco en puerta de salida")
            if incidencia.endswith("azul"):
                print("Reponer aceite en cinta")
    else:
        print("INCIDENCIA NO RECONOCIDA")
    
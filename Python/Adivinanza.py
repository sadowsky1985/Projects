def Adivinanza(intentos=1):
    respuesta = input("¿De qué color es el caballo blanco de Espartero? ")
    if respuesta != "blanco":
        if intentos < 3:
            intentos += 1
            print("Fallaste!!! Inténtelo de nuevo")
            Adivinanza(intentos)
        else:
            print("Perdiste!!! Se acabaron las oportunidades")
    else:
        print("Ganaste!!! Acertado en "+ str(intentos) + " intento(s)")

Adivinanza()
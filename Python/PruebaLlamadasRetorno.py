"""Programa para demostrar el funcionamiento de las llamadas de retorno.

Se crean tres funciones diferenciadas por un número, y se llama de forma dinámica mediante la función globals().

"""

def nivel1():
    'Es la primera función definida'
    return "Este es el Nivel 1"

def nivel2():
    "Es la segunda función definida"
    return "Este es el Nivel 2"

def nivel3():
    """Es la tercera función definida"""
    return "Este es el Nivel 3"

def iniciar():
    """Es la función principal.
    
    Solicita al usuario un número, que sercirá para formar el nombre de función que será llamada.
    También se comprueba si dicha función no existe.
    
    """
    num = input("Indique el nivel que necesita: ")
    if "nivel" + num in globals():
        if callable(globals()["nivel" + num]):
            print(globals()["nivel" + num]())
    else:
        print("El nivel " + num + " no existe")
    
iniciar()

print("Documentación nivel1: " + nivel1.__doc__)
print("Documentación iniciar: " + iniciar.__doc__)
print("Documentación general: " + __doc__)
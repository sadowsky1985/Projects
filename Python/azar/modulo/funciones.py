import random


def azar(numero):
    numero = random.randint(1, numero)
    return numero

def mensajeAcierto():
    print("¡acertaste!")

def mensajeFallo():
    print("¡Lo siento, fallaste!")

def mensajeFin(numero):
    print("¡No hay oprtunidades, no acertaste! El número era el " + str(numero))

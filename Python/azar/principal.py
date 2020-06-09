from azar.modulo.funciones import azar as suerte
from azar.modulo.funciones import mensajeAcierto as acierto
from azar.modulo.funciones import mensajeFallo as fallo
from azar.modulo.funciones import mensajeFin as fin

numeroAzar = suerte(10)
intentos = 1
Acierto = False
while intentos <= 3 and Acierto is False:
    numeroUsuario = eval(input("Escriba un número (maximo 10): "))
    if numeroAzar == numeroUsuario:
        acierto()
        Acierto = True
    else:
        fallo()
    intentos += 1
if Acierto is False:
    fin(numeroAzar)
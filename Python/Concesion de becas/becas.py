from PyQt5.QtWidgets import *
from PyQt5 import uic


def agregar():
    global fichero
    fichero = open("solicitantes.txt", "a+")
    minombre = ventana.nombre.text()
    miapellido = ventana.apellidos.text()
    miexpediente = ventana.expediente.text()
    minombrecompleto = miapellido + ", " + minombre
    if (not minombre) or (not miapellido) or (not miexpediente):
        mensajerror = QMessageBox()
        mensajerror.warning(ventana, "ERROR", "Debe escribir número de expediente, nombre y apellidos", mensajerror.Ok)
    else:
        if ventana.BecaSi.isChecked():
            registro = miexpediente.ljust(10).title() + minombrecompleto.ljust(40).title() + "S" + "\n"
        if ventana.BecaNo.isChecked():
            registro = miexpediente.ljust(10).title() + minombrecompleto.ljust(40).title() + "N" + "\n"
        fichero.write(registro)
        frase = "Registro añadido:\n" + registro
        mensaje(frase)
        ventana.nombre.setText("")
        ventana.apellidos.setText("")
        ventana.expediente.setText("")



def capacidadarchivo():
    global fichero
    fichero.close()
    fichero = open("solicitantes.txt", "a")
    longitud = fichero.tell()
    fichero.close()
    fichero = open("solicitantes.txt", "a+")
    return longitud


def mensaje(texto):
    mensaje = QMessageBox()
    mensaje.information(ventana, "Resultado", texto, mensaje.Ok)


def mensajeSi(texto):
    mensaje = QMessageBox()
    mensaje.information(ventana, "ALUMNOS CON BECAS ASIGNADAS", texto, mensaje.Ok)


def mensajeNo(texto):
    mensaje = QMessageBox()
    mensaje.information(ventana, "ALUMNOS CON BECAS DENEGADAS", texto, mensaje.Ok)


def listarasignadas():
    final = capacidadarchivo() - 52
    actual = 0
    fichero.seek(actual)
    frase = "EXPEDIENTE".ljust(14) + "ALUMNO".ljust(40) + "\n".ljust(54, "-") + "\n"
    while actual <= final:
        expediente = fichero.read(10)
        nombrecompleto = fichero.read(41)
        beca = fichero.read(1)
        #print(expediente + "##" + nombrecompleto + "##" + beca+ "##")
        if beca == "S":
            frase += expediente.ljust(20) + nombrecompleto.ljust(40) + "\n"
        actual += 52
    mensajeSi(frase)


def listardenegadas():
    final = capacidadarchivo() - 52
    actual = 0
    fichero.seek(actual)
    frase = "EXPEDIENTE".ljust(14) + "ALUMNO".ljust(40) + "\n".ljust(54, "-") + "\n"
    while actual <= final:
        expediente = fichero.read(10)
        nombrecompleto = fichero.read(41)
        beca = fichero.read(1)
        #print(expediente + "##" + nombrecompleto + "##" + beca + "##")
        if beca == "N":
            frase += expediente.ljust(20) + nombrecompleto.ljust(40) + "\n"
        actual += 52
    mensajeNo(frase)

global fichero
fichero = open("solicitantes.txt", "a+")


app = QApplication([])
ventana = uic.loadUi("ventanaBecas.ui")
ventana.agregar.clicked.connect(agregar)
ventana.asignadas.clicked.connect(listarasignadas)
ventana.denegadas.clicked.connect(listardenegadas)
ventana.show()
app.exec_()
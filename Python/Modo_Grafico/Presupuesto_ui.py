from PyQt5.QtWidgets import *
from PyQt5 import uic

def calculapre():
    #objeto QCalendarWidget
    fecha = ventana.calendario.selectedDate()
    plusFecha = 0 # Añadido debido a Error.  no estar declarada antes de usada !!!
    if fecha.month() == 8: #Si es agosto se paga un plus
        plusFecha = 200
    else:
        plusFecha = 0
    # Objeto QComboBox
    destino = ventana.destinos.currentText()
    if destino == "Europa":
        plusDestino = 150
    elif destino == "Asia":
        plusDestino = 450
    else:
        plusDestino = 600
    # Objeto QRadioButton
    if ventana.envioEstandar.isChecked():
        plusEnvio = 0
    else:
        plusEnvio = 80
    #objeto QLineEdit
    plusPeso = eval(ventana.peso.text())
    precio = plusPeso + plusFecha + plusDestino + plusEnvio
    ventana.resultado.setText(str(precio) + " €")

app = QApplication([])
ventana = uic.loadUi("misventanas\\Ventana_Presupuesto.ui")
ventana.setWindowTitle("Cálculo de Presupuestos")
ventana.calcular.clicked.connect(calculapre)
ventana.show()
app.exec_()

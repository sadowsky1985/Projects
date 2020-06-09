from PyQt5.QtWidgets import *
from misventanas.Ventana_Presupuesto_Python import Ui_MainWindow

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
ventana = Ui_MainWindow()
local = QMainWindow()

ventana.setupUi(local)
ventana.calcular.clicked.connect(calculapre)
local.setWindowTitle("Cálculo de Presupuestos")
local.show()
app.exec_()
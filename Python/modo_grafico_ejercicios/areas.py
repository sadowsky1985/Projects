from PyQt5.QtWidgets import *

def calculaTri():
    base = float(cuadroBase.text())
    altura = float(cuadroAltura.text())
    operacion = base * altura / 2
    mensaje = "Resultado: %4.3f" % operacion
    labelResultado.setText(mensaje)


def calculaRec():
    base = float(cuadroBase.text())
    altura = float(cuadroAltura.text())
    operacion = base * altura
    mensaje = "Resultado: %4.3f" % operacion
    labelResultado.setText(mensaje)


def calculaCi():
    base = float(cuadroBase.text())
    altura = float(cuadroAltura.text())
    operacion = 2 * 3.141516 * base * altura
    mensaje = "Resultado: %4.3f" % operacion
    labelResultado.setText(mensaje)



app = QApplication([])
w = QWidget()
w.setWindowTitle("Cálculo de áreas")
w.setFixedSize(320, 240)
w.move(200, 200)
capa1 = QGridLayout()
labelBase = QLabel("Base/Radio")
labelAltura = QLabel("Altura")
labelResultado = QLabel("Resultado: ")
cuadroBase = QLineEdit()
cuadroAltura = QLineEdit()
botonTri = QPushButton("Triángulo")
botonRec = QPushButton("Rectángulo")
botonCi = QPushButton("Cilindro")

grid = QGridLayout()
grid.addWidget(labelBase, 1, 0)
grid.addWidget(cuadroBase, 1, 1)
grid.addWidget(labelAltura, 2, 0)
grid.addWidget(cuadroAltura, 2, 1)
grid.addWidget(labelResultado, 4, 1)
grid.addWidget(botonTri, 3, 0)
grid.addWidget(botonRec, 4, 0)
grid.addWidget(botonCi, 5, 0)

base = cuadroBase.text()
altura = cuadroAltura.text()
w.setLayout(grid)

botonTri.clicked.connect(calculaTri)
botonCi.clicked.connect(calculaCi)
botonRec.clicked.connect(calculaRec)


w.show()
app.exec_()





from PyQt5.QtWidgets import *
app = QApplication([])
w = QWidget()
w.setWindowTitle("Primera ventana en PyQT")
w.resize(350, 150)
# Si deseamos un tamaño fijo: w.setFixedSize(ancho, alto)
w.move(300, 300)
milayout = QHBoxLayout()
boton1 = QPushButton("Primer botón")
boton2 = QPushButton("Segundo botón")
etiq1 = QLabel("Etiqueta 1")
etiq2 = QLabel("Etiqueta 2")
milayout.addWidget(etiq1)
milayout.addWidget(boton1)
milayout.addWidget(etiq2)
milayout.addWidget(boton2)
w.setLayout(milayout)
w.show()
app.exec_()


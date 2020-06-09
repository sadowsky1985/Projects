from PyQt5.QtWidgets import *
app = QApplication([])

def abandonar():
    mensaje = QMessageBox()
    respuesta = mensaje.information(w, "Cerrar", "¿Desea cerrar?", mensaje.Ok, mensaje.Cancel)
    if respuesta == mensaje.Ok:
        app.instance().quit()

def enviarform():
    f = QDialog(w)
    f.setWindowTitle("Formulario")
    f.resize(200, 250)
    f.setFixedWidth(200)
    formnombre = QLabel("Nombre:\n" + Cuadronombre.text())
    formemail = QLabel("Email:\n" + Cuadroemail.text())
    formpetic = QLabel("Petición:\n" + Cuadropetic.toPlainText())
    formpetic.setWordWrap(True)
    cierradialog = QPushButton("Cerrar")
    cierradialog.clicked.connect(f.close)
    g = QVBoxLayout()
    g.addWidget(formnombre)
    g.addWidget(formemail)
    g.addWidget(formpetic)
    g.addWidget(cierradialog)
    f.setLayout(g)
    f.show()
    Cuadronombre.setText("(enviado)")
    Cuadroemail.setText("(enviado)")
    Cuadropetic.setText("(enviado)")

w = QWidget()
w.setWindowTitle("Formulario de peticiones")
w.resize(350, 250)
nombre = QLabel("Nombre:")
email = QLabel("Email:")
petic = QLabel("Petición:")

Cuadronombre = QLineEdit()
Cuadroemail = QLineEdit()
Cuadropetic = QTextEdit()

enviar = QPushButton("Enviar")
cerrar = QPushButton("Cerrar")
cerrar.clicked.connect(abandonar)
enviar.clicked.connect(enviarform)

grid = QGridLayout()
grid.setSpacing(15)

grid.addWidget(nombre, 1, 0)
grid.addWidget(Cuadronombre,1 ,1 ,1 ,2)

grid.addWidget(email, 2, 0)
grid.addWidget(Cuadroemail, 2, 1, 1, 2)

grid.addWidget(petic, 3, 0)
grid.addWidget(Cuadropetic, 3, 1, 5, 2)
grid.addWidget(enviar, 8, 1)
grid.addWidget(cerrar, 8, 2)
w.setLayout(grid)
w.show()
app.exec_()
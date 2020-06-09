# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'Ventana_Presupuesto.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(454, 434)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.calendario = QtWidgets.QCalendarWidget(self.centralwidget)
        self.calendario.setGeometry(QtCore.QRect(10, 70, 241, 171))
        self.calendario.setObjectName("calendario")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(70, 10, 250, 20))
        font = QtGui.QFont()
        font.setPointSize(14)
        font.setBold(True)
        font.setWeight(75)
        self.label.setFont(font)
        self.label.setAlignment(QtCore.Qt.AlignCenter)
        self.label.setObjectName("label")
        self.label_2 = QtWidgets.QLabel(self.centralwidget)
        self.label_2.setGeometry(QtCore.QRect(270, 70, 35, 10))
        self.label_2.setObjectName("label_2")
        self.destinos = QtWidgets.QComboBox(self.centralwidget)
        self.destinos.setGeometry(QtCore.QRect(260, 90, 53, 22))
        self.destinos.setObjectName("destinos")
        self.destinos.addItem("")
        self.destinos.addItem("")
        self.destinos.addItem("")
        self.groupBox = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBox.setGeometry(QtCore.QRect(260, 130, 120, 80))
        self.groupBox.setObjectName("groupBox")
        self.envioEstandar = QtWidgets.QRadioButton(self.groupBox)
        self.envioEstandar.setGeometry(QtCore.QRect(10, 20, 62, 14))
        self.envioEstandar.setChecked(True)
        self.envioEstandar.setObjectName("envioEstandar")
        self.envioUrgente = QtWidgets.QRadioButton(self.groupBox)
        self.envioUrgente.setGeometry(QtCore.QRect(10, 50, 62, 14))
        self.envioUrgente.setObjectName("envioUrgente")
        self.label_3 = QtWidgets.QLabel(self.centralwidget)
        self.label_3.setGeometry(QtCore.QRect(260, 220, 35, 16))
        self.label_3.setObjectName("label_3")
        self.peso = QtWidgets.QLineEdit(self.centralwidget)
        self.peso.setGeometry(QtCore.QRect(310, 220, 71, 20))
        self.peso.setObjectName("peso")
        self.calcular = QtWidgets.QPushButton(self.centralwidget)
        self.calcular.setGeometry(QtCore.QRect(20, 260, 81, 17))
        self.calcular.setObjectName("calcular")
        self.resultado = QtWidgets.QLabel(self.centralwidget)
        self.resultado.setGeometry(QtCore.QRect(110, 260, 141, 16))
        self.resultado.setText("")
        self.resultado.setObjectName("resultado")
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 454, 18))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "MainWindow"))
        self.label.setText(_translate("MainWindow", "Presupuesto de envío"))
        self.label_2.setText(_translate("MainWindow", "Destino:"))
        self.destinos.setItemText(0, _translate("MainWindow", "Europa"))
        self.destinos.setItemText(1, _translate("MainWindow", "Asia"))
        self.destinos.setItemText(2, _translate("MainWindow", "E.E.U.U."))
        self.groupBox.setTitle(_translate("MainWindow", "Modo de envío"))
        self.envioEstandar.setText(_translate("MainWindow", "Estándar"))
        self.envioUrgente.setText(_translate("MainWindow", "Urgente"))
        self.label_3.setText(_translate("MainWindow", "Peso (kg.):"))
        self.calcular.setText(_translate("MainWindow", "Calcular presupuesto"))

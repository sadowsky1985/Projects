from clases.convertidor import *


class cuentabancaria(convertidor):
    def __init__(self, minumCuenta, micambio, micantMon):
        super(cuentabancaria, self).__init__(micambio)
        self.numCuenta = minumCuenta
        self.moneda = "e"
        self.cantidad_euros(micantMon)

    def moneda_actual(self, mimoneda):
        if mimoneda == "e":
            self.moneda == "e"
        elif mimoneda == "d":
            self.moneda == "d"
        else:
            raise TypeError("Tipo de moneda no válido")

    def ingresar(self, micantMon):
        if self.moneda == "e":
            self.cantidad_euros(self.muestra_euros() + micantMon)
        elif self.moneda == "d":
            self.cantidad_dolares(self.muestra_dolares() + micantMon)
        else:
            raise TypeError("Debe indicar el tipo de moneda")

    def retirar(self, micantMon):
        if self.moneda == "e":
            self.cantidad_euros(self.muestra_euros() - micantMon)
        elif self.moneda == "d":
            self.muestra_dolares(self.cantidad_dolares() - micantMon)
        else:
            raise TypeError("Debe indicar el tipo de moneda")



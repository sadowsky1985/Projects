class convertidor():
    def __init__(self, micambio):
        self.cambio = micambio
        self.cantEur = 0
        self.cantDol = 0

    def cantidad_euros(self, valor):
        self.cantEur = valor
        self.cantDol = valor * self.cambio

    def cantidad_dolares(self, valor):
        self.cantDol = valor
        self.cantEur = valor / self.cambio

    def muestra_euros(self):
        return round(self.cantEur, 2)

    def muestra_dolares(self):
        return round(self.cantDol, 2)

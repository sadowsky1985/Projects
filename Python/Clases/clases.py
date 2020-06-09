class Coordenada:
    def __init__(self, valorx=0, valory=0):
        if isinstance(valorx, (int, float)):
            self.x = valorx
        else:
            raise TypeError("valor x no válido: debe ser numérico")
        if isinstance(valory, (int, float)):
            self.y = valory
        else:
            raise TypeError("valor y no válido: debe ser numérico")

    def __str__(self):
        return "(" + str(self.x) + ", " + str(self.y) + ")"

    def __add__(self, otra):
        return Coordenada(self.x + otra.x, self.y + otra.y)

    def __sub__(self, otra):
        return Coordenada(self.x - otra.x, self.y - otra.y)

    def distancia(self, otra):
        # distx = otra.x - self.x
        # disty = otra.y - self.y
        # return((distx * distx) + (disty * disty)) ** 0.5
        nuevacoor = self.restar(otra)
        return nuevacoor.norma()

    def restar(self, otra):
        return Coordenada(otra.x - self.x, otra.y - self.y)

    def norma(self):
        return ((self.x * self.x) + (self.y * self.y)) ** 0.5


try:
    coor1 = Coordenada(0, 0)
    coor2 = Coordenada(10, 10)
    print("Primera coordenada: %i, %i" % (coor1.x, coor1.y))
    print("Segunda coordenada: %i, %i" % (coor2.x, coor2.y))
    coor3 = coor1.restar(coor2)
    print("Coordenada de la resta: %i, %i" % (coor3.x, coor3.y))
    norma = coor3.norma()
    print("Norma (distancia):", norma)
    print("Coincide con Distancia:", coor1.distancia(coor2))
    inicial = Coordenada(35, 78)
    print("\nLa coordenada creada es: " + str(inicial))
    print("El lo mismo que imprimirla directamente:", inicial)
    inicio = Coordenada(100, 100)
    fin = Coordenada(250, 250)
    print("\nPrimera coordenada:", inicio)
    print("Segunda coordenada: ", fin)
    print("La suma de coordenadas es", inicio + fin)
    print("La resta de coordenadas es", inicio - fin)

except TypeError as textoerror:
    print(textoerror)

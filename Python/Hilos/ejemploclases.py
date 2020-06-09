import threading
import time

class MiHilo(threading.Thread):
    def __init__(self, valor):
        self.valor = valor
        super().__init__()

    def run(self):
        print("El valor transmitido es:", self.valor)
        time.sleep(.5)
        print("Fin del thread con valor", self.valor)

class MiOperador():
    def __init__(self, valor=1):
        self.numero = valor

    def factorial(self, valor="nada"):
        # si no indicamos ningún valor como parámetro, trabajaremos
        # con el indicado en el constructor
        if valor != "nada":
            self.numero = valor
        total = 1
        for valor in range(1, self.numero +1):
            total *= valor
            time.sleep(.05)
        print("Factorial de", self.numero, "es", total)


print("Lanzamos 5 threads como clases")
for i in range(5):
    hilo = MiHilo(i)
    hilo.start()
    hilo.join()

print("\nEjecutamos el método de un objeto, de forma normal")
calculadora1 = MiOperador(60)
calculadora2 = MiOperador()
calculadora3 = MiOperador(15)
calculadora4 = MiOperador(7)
inicio = time.time() # anotamos el momento inicial
calculadora1.factorial()
calculadora2.factorial(12)
calculadora3.factorial()
calculadora4.factorial()
final = time.time()
print("Tiempo tardado:", final-inicio)

print("\nEjecutamos el mismo método como thread")
hilo1 = threading.Thread(target=calculadora1.factorial)
hilo2 = threading.Thread(target=calculadora2.factorial)
hilo3 = threading.Thread(target=calculadora3.factorial)
hilo4 = threading.Thread(target=calculadora4.factorial)
inicio = time.time()
hilo1.start() # Será el que más tiempo tarde
hilo2.start()
hilo3.start()
hilo4.start()
hilo1.join() # esperamos a que finalice el que más tarda
final = time.time()
print("Tiempo tardado:", final-inicio)
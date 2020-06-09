import threading
import random
import logging
import time


class concursante(threading.Thread):
    def __init__(self, valor):
        self.nombre = valor
        super().__init__()

    def run(self):
        logging.info("Participante %s comienza.", self.nombre)
        espera = random.randint(1, 15)
        time.sleep(espera)
        logging.info("Participante %s llega a la meta. Tiempo: %d segundos", self.nombre, espera)
        self.tiempo = espera
        barrera.wait()

def carrera():
    logging.info("Preparando la carrera... Hay %d participantes" % (barrera.parties-1))
    barrera.wait()
    podio = []
    podio.append((concu1.tiempo, concu1.nombre))
    podio.append((concu2.tiempo, concu2.nombre))
    podio.append((concu3.tiempo, concu3.nombre))
    podio.sort()
    logging.info("Fin de la carrera! Ganador: Concursante %s en %s segundos" % (podio[0][1], podio[0][0]))


logging.basicConfig(format="%(asctime)s: %(message)s", level=logging.INFO,
                    datefmt="%H:%M:%S")
barrera = threading.Barrier(4)
concu1 = concursante("Pedrito")
concu2 = concursante("Juanito")
concu3 = concursante("Martita")
micarrera = threading.Thread(target=carrera)
micarrera.start()
concu1.start()
concu2.start()
concu3.start()




import time
import logging
import concurrent.futures

def desglose(listado):
    nombre = listado[0]
    compra = listado[1:]
    logging.debug("Contabilizando compra de %s", nombre)
    total = 0
    for precio in compra:
        total += precio
        time.sleep(0.2)
    logging.debug("Total a cobrar a %s: %d", nombre, total)


logging.basicConfig(level=logging.DEBUG, format="%(asctime)s (%(levelname)s): %(message)s", datefmt="%H:%M:%S")
cliente1 = ("Jose", 100, 200, 300, 400, 500)
cliente2 = ("Marisa", 50, 70, 10, 20, 50, 70, 10, 20)
cliente3 = ("Patri", 2000, 3500, 5000)
cliente4 = ("Carlos", 85000, 25000, 130000)
clientes = (cliente1, cliente2, cliente3, cliente4)
with concurrent.futures.ThreadPoolExecutor(max_workers=3) as ejecutor:
    ejecutor.map(desglose, clientes)
import threading
import time
import logging


def trabajo(numero):
    logging.info("Thread %s: iniciado", numero)
    time.sleep(3)
    logging.info("Thread %s: finalizado", numero)


logging.basicConfig(format="%(asctime)s: %(message)s", level=logging.INFO, datefmt="%H:%M:%S")
hilos = list()
for num in range(3):
    logging.info("Thread principal, crea y lanza thread %d.", num)
    hilo = threading.Thread(target=trabajo, args=(num,))
    hilos.append(hilo)
    hilo.start()

for num, mihilo in enumerate(hilos):
    logging.info("Thread principal, esperando al thread %d.", num)
    mihilo.join()
    logging.info("Thread principal, thread %d finalizado", num)

# hilo = threading.Thread(target=trabajo, args=(1,), daemon=True)
# # hilo.setDaemon(True) sería una alternativa
# logging.info("Thread principal, iniciado")
# hilo.start()
# logging.info("Thread principal, esperando a que finalice el thread")
# hilo.join()
# logging.info("Thread principal, finalizado")
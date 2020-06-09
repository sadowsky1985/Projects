import os
import sys
import random
print("EJEMPLOS MODULO OS")
print("Carpeta de trabajo actual: ", os.getcwd())
if(os.path.exists(os.getcwd() + "\\soluciones")):
    print("Dispone de una carpeta de soluciones")
else:
    print("La carpeta de soluciones no se encuentra")

def plataforma(dato):
    if dato.startswith('linux'):
        return "Linux"
    elif dato.startswith('darwin'):
        return "Mac OS X"
    elif dato.startswith('win32'):
        return "Windows"
    else:
        return "(no reconocido)"

print("\nEJEMPLOS MODULO SYS")
print("La ruta y nombre del intérprete Python es", sys.executable)
print("La plataforma de trabajo es", plataforma(sys.platform))
print("La información sobre esta versión de Python es %d.%d.%d" % (sys.version_info.major, sys.version_info.minor, sys.version_info.micro))

print("\nEJEMPLOS MODULO RANDOM")
random.seed()
linea = "Diversos números al azar entre 1 y 10:\n"
for contador in range(10):
    linea = linea + " " + str(random.randint(1, 10))
print(linea)

print("Otro ejemplo de 5 números al azar entre 100 y 200: %s" % random.sample(range(100, 200), 5))

lista = ["Barcelona", "Girona", "Lleida", "Tarragona"]
print("una provincia al azar: %s" % random.choice(lista))
print("Dos provincias al azar: %s" % random.sample(lista, 2))
random.shuffle(lista) # Se modifica la propia lista
print("Todas las provincias mezcladas: %s" % lista)
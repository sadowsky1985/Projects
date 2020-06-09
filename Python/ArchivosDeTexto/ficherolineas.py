fichero = open("paises y capitales.txt", "a+")


def agregar():
    print("\nAGREGAR PAIS/CAPITAL")
    pais = input("Escriba el país: ")
    capital = input("Escriba la capital: ")
    fichero.write(pais + "\n")
    fichero.write(capital + "\n")


def buscar():
    print("\nBUSCAR")
    mipais = input("Escriba el país a buscar: ")
    # Establecemos primera letra mayúscula y resto minusculas
    mipais = mipais.title()
    fichero.seek(0)
    pais = "comenzamos"
    micapital = "Lo siento, no se encuentra ese país."
    while pais != "":
        # A cada dato leido le aplicamos el mismo formato que en la pregunta
        pais = fichero.readline().title()
        capital = fichero.readline().title()
        if pais == mipais + "\n":
            micapital = "La capital de " + mipais + " es " + capital
    print(micapital)

def listar():
    print("\nLISTADO")
    fichero.seek(0)
    contenido = fichero.readlines()
    print("Contenido exacto:")
    print(contenido)
    print("Contenido controlado:")
    print("PAÍS".ljust(20) + "CAPITAL")
    print("-".center(30, "-"))
    pais ="comenzamos"
    fichero.seek(0)
    while pais != "":
        # Leemos cada línea y eliminamos el salto de línea del final"
        pais = fichero.readline().replace("\n", "")
        capital = fichero.readline().replace("\n", "")
        print(pais.ljust(20).title() + capital.ljust(20).title())

opcion = ""
while opcion != "0":
    print("\n\nMENU DE OPCIONES")
    print("1 - Añadir país/capital")
    print("2 - Buscar")
    print("3 - Listado")
    print("0 - Salir")
    opcion = input("Indique la opción: ")
    if opcion == "1":
        agregar()
    if opcion == "2":
        buscar()
    if opcion == "3":
        listar()
fichero.close()
print("\nFin del programa.")
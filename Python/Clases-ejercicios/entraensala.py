from datetime import date, time, datetime

def festivo(funcion):
    lista = [date(2020, 1, 6), date(2020, 11, 1), date(2020, 8, 15), date(2020, 12, 25)]
    def comprueba(*args):
        hoy = datetime.today().date()
        print("Días festivos:")
        acceso = True
        for dia in lista:
            print(dia.day, "del mes", dia.month, end="   ")
            if (dia.day == hoy.day) and (dia.month == hoy.month):
                acceso = False
        print("\nHoy es", hoy.day, "del mes", hoy.month)
        if acceso:
            funcion(*args)
        else:
            print("Acceso denegado! Es día festivo!")
    return comprueba

def horario(funcion):
    def comprueba(*args):
        apertura = time(9, 0, 0)
        cierre = time(15, 45, 0)
        hora = datetime.today().time()
        print("El horario de la sala es de ", apertura.isoformat("minutes"), " a ", cierre.isoformat("minutes"))
        print("Ahora son las " + hora.isoformat("minutes"))
        if (hora >= apertura) and (hora <= cierre):
            funcion(*args)
        else:
            TypeError("No puede entrar. Fuera de horario.")
    return comprueba

@festivo
@horario
def entrar():
    nombre = input("Ingrese su nombre de usuario: ")
    print("Adelante, puede pasar.")


entrar()
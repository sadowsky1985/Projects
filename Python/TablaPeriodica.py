TablaPeriodica = "Aluminio", "Al", "Azufre", "S", "Bismuto", "Bi", "Cloro", "Cl", "Mercurio", "Hg"
    

def BuscaSimbolo(Simbolo):
    if TablaPeriodica.count(Simbolo) == 0:
        print("Símbolo no encontrado.")
    else:
        if TablaPeriodica.index(Simbolo) / 2 == TablaPeriodica.index(Simbolo) //2:
            print("Símbolo no encontrado.")
        else:
            print(Simbolo.ljust(15, ".") + TablaPeriodica[TablaPeriodica.index(Simbolo) -1].rjust(10, "."))      

def BuscaElemento(Elemento):
    if TablaPeriodica.count(Elemento) == 0:
        print("Elemento no encontrado.")
    else:
        if TablaPeriodica.index(Elemento) /2 != TablaPeriodica.index(Elemento) //2:
            print("Elemento no encontrado.")
        else:
            print(Elemento.ljust(15, ".") + TablaPeriodica[TablaPeriodica.index(Elemento) +1].rjust(10, "."))
        

opcion = -1
while opcion != 0:
    print("TABLA PERIÓDICA - MENÚ DE OPCIONES")
    print("1 - Buscar por elemento")
    print("2 - Buscar por símbolo")
    print("0 - Salir")
    opcion = eval(input("Escribe opción: "))
    if opcion == 1:
        Elemento=input("Escribe el nombre del elemento químico: ")
        BuscaElemento(Elemento)
    if opcion == 2:
        Simbolo = input("Escribe el símbolo del elemento químico: ")
        BuscaSimbolo(Simbolo)
print("Gracias por usar este programa.")
        
    
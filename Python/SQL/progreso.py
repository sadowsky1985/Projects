import mysql.connector
import random

conex = mysql.connector.connect(user="root", password="root", host="localhost")
cursor = conex.cursor()
cursor.execute("CREATE DATABASE IF NOT EXISTS python_ejercicios")
cursor.execute("USE python_ejercicios")

def creacion():
    cursor.execute("DROP TABLE IF EXISTS progresion")
    cursor.execute("CREATE TABLE progresion (anyo INTEGER, poblacion CHAR(20), sueldos INTEGER, "
                   + "equipamiento INTEGER, ganancias INTEGER, PRIMARY KEY(anyo, poblacion))")
    print("Tabla creada sin registros")

def rellenar():
    ciudades = ["Sabadell", "Martorell", "Sant Cugat"]
    for anyo in range(2019, 2023):
        for ciudad in ciudades:
            sueldo = random.randint(50000, 100000)
            equipamiento = random.randint(50000, 80000)
            ganancia = random.randint(80000, 200000)
            cursor.execute("INSERT INTO progresion VALUES(%s, %s, %s, %s, %s)", (anyo, ciudad, sueldo, equipamiento, ganancia))
    conex.commit()
    print("Datos introducidos en tabla 'progresion'")

def listado():
    cursor.execute("SELECT anyo, poblacion, sueldos, equipamiento, ganancias,  "
                   + "ganancias - (sueldos + equipamiento) as balance FROM progresion")
    print("LISTADO GENERAL CON BALANCE\nAño\t\tPoblación\tSueldos\t\tEquipamiento\tGanancias\tBalance")
    print("-" * 60)
    for reg in cursor:
        print('{0}\t{1}\t{2}€\t{3}€\t\t\t{4}€\t\t{5}€'.format(reg[0], reg[1], reg[2], reg[3], reg[4], reg[5]))


def listadoagrupado():
    cursor.execute("SELECT poblacion, sum(sueldos), sum(equipamiento), sum(ganancias),  "
                   + "sum(ganancias - (sueldos+equipamiento)) as balance FROM progresion GROUP BY poblacion")
    print("LISTADO GENERAL AGRUPADO\nPoblación\tSueldos\t\tEquipamiento\tGanancias\tBalance")
    print("-" * 60)
    for reg in cursor:
        print('{0}\t{1}€\t\t{2}€\t\t\t{3}€\t\t{4}€'.format(reg[0], reg[1], reg[2], reg[3], reg[4]))


opcion = ""
while opcion != "0":
    print("\nMENÚ DE OPCIONES")
    print("1- Crear tabla")
    print("2- Rellenar con datos aleatorios")
    print("3- Listado con balance")
    print("4- Listado agrupado por población")
    print("0 - SALIR")
    opcion = input("Indica una opción: ")
    if opcion == "1":
        creacion()
    if opcion == "2":
        rellenar()
    if opcion == "3":
        listado()
    if opcion == "4":
        listadoagrupado()
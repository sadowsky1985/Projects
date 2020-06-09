import xml.etree.ElementTree as ET


def crear():
    principal = ET.Element("verduras")
    datos = ET.tostring(principal, encoding="unicode")
    archivo = open("xml_listadoverduras.xml", "w")
    archivo.write(datos)
    archivo.close()
    print("Archivo XML creado, sin estructura!")


def agregar():
    arbol = ET.parse("xml_listadoverduras.xml")
    raiz = arbol.getroot()
    print("\nAGREGAR NUEVA VERDURA")
    miID = input("ID del producto: ")
    existe = False
    for etiqueta in raiz:
        if etiqueta.attrib["id"] == miID:
            existe = True
    if existe:
        print("Este ID de producto ya existe!")
    else:
        minombre = input("Nombre de la verdura: ")
        mitipo = input("Tipo de producto: ")
        miorigen = input("Origen (continente): ")

        producto = ET.SubElement(raiz, "producto")
        nombre = ET.SubElement(producto, "nombre")
        tipo = ET.SubElement(producto, "tipo")
        origen = ET.SubElement(producto, "origen")

        producto.set("id", miID)
        nombre.set("id", "Nombre de la verdura")
        nombre.text = minombre
        tipo.set("id", "Tipo")
        tipo.text = mitipo
        origen.set("id", "Origen")
        origen.text = miorigen
        arbol.write("xml_listadoverduras.xml")


def eliminar():
    arbol = ET.parse("xml_listadoverduras.xml")
    raiz = arbol.getroot()
    print("\nELIMINAR UNA VERDURA")
    numero = input("Dime ID del producto a eliminar: ")
    encontrado = False
    for etiqueta in raiz:
        if etiqueta.attrib["id"] == numero:
            encontrado = True
            raiz.remove(etiqueta)
    if encontrado:
        print("Producto %s eliminado." % numero)
        arbol.write("xml_listadoverduras.xml")
    else:
        print("El producto %s no se ha localizado." % numero)


def listado():
    arbol = ET.parse("xml_listadoverduras.xml")
    raiz = arbol.getroot()
    print("\nLISTADO DE VERDURAS\nCantidad catalogada:", len(raiz), "\n", "-" * 100)
    for etiqueta in raiz:
        print("ID Producto:", etiqueta.attrib["id"], end="     ")
        for subetiqueta in etiqueta:
            texto = subetiqueta.attrib["id"] + ": " + subetiqueta.text
            print(texto.ljust(30), end="     ")
        print()


opcion = ""
while opcion != "0":
    print("\nMENÚ PRINCIPAL")
    print("1 - Crear archivo XML")
    print("2 - Añadir una verdura")
    print("3 - Eliminar una verdura")
    print("4 - Listado")
    print("0 - Salir")
    opcion = input("Escribe una opción: ")
    if opcion == "1":
        crear()
    if opcion == "2":
        agregar()
    if opcion == "3":
        eliminar()
    if opcion == "4":
        listado()

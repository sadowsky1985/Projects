import json


def anotacompra(lista):
    articulo = ""
    while articulo != "salir":
        articulo = input("Número de artículo ('salir' para finalizar): ")
        if articulo != "salir":
            cantidad = input("Cantidad comprada: ")
            lista.append({"codigo": articulo, "cantidad": cantidad})


archivo = open("json_socios.json", "r")
mijson = json.load(archivo)
archivo.close()
numsocio = input("Escribe el número de socio: ")
print("\nBUSQUEDA DE SOCIO:")
noexiste = True
for socio in mijson["socios"]:
    if socio["num socio"] == numsocio:
        noexiste = False
        print("COMPRAS DEL SOCIO %s, %s" % (socio["num socio"], socio["nombre"]))
        anotacompra(socio["compras"])
if noexiste:
    print("El socio %s no existe, le damos de alta" % numsocio)
    nombre = input("Nombre del socio: ")
    compras = []
    anotacompra(compras)
    mijson["socios"].append({"num socio": numsocio, "nombre": nombre, "compras": compras})

archivo = open("json_socios.json", "w")
json.dump(mijson, archivo, ensure_ascii=False, indent=2)
archivo.close()
print("Guardarmos todos los cambios realizados, de esta manera:\n", mijson)

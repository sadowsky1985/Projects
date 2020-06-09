articulos = "Abrigo", 85.35, "Camisa", 32.45, "Zapatos", 28.15

def imprime(listado):
    contador = 0
    while contador <  len(listado):
        print(listado[contador].ljust(10) + str(listado[contador + 1]).rjust(5) + "€")
        contador += 2

def esprecio(elem):
    if isinstance(elem, str):
        return False
    else:
        return elem

def esarticulo(elem):
    valor = elem if isinstance(elem, str) else False
    return valor

def descuentos(elem):
    if elem >= 50: # Si es 50 o más, 30 % descuento
        elem -= (elem * 0.3)
    elif elem >= 30: # Si es 30 o más, 20 % descuento
        elem -= (elem * 0.2)
    return elem

print("Los artículos comprados son: ")
imprime(articulos)

# soloprecios = tuple(filter(esprecio, articulos))
# soloarticulos = tuple(filter(esarticulo, articulos))
soloprecios = tuple(filter(lambda e:False if isinstance(e, str) else e, articulos))
soloarticulos = tuple(filter(lambda e:e if isinstance(e, str) else False, articulos))
preciosconDescuento = tuple(map(descuentos, soloprecios))

#Se cobran 2 euros por la gestión
print("El total de los artículos es %4.2f€" % sum(soloprecios, 2))
print("El total con descuento es %4.2f€" % sum(preciosconDescuento, 2))

articulos_final = tuple(zip(soloarticulos, preciosconDescuento))
print("\nListado final de artículos: ")
for artic in articulos_final:
    print("%3.2f€ ... %s" % (artic[1], artic[0]))
        
              
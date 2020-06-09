art1 = input("Primer artículo: ")
precioart1 = eval(input("Precio: "))
art2 = input("Segundo artículo: ")
precioart2 = eval(input("Precio: "))
art3 = input("Tercer artículo: ")
precioart3 = eval(input("Precio: "))

preciobase = precioart1 + precioart2 + precioart3
iva = preciobase * 21 / 100
total = preciobase + iva

textpreciobase = str(preciobase)
textpreciobase = textpreciobase[:textpreciobase.find(".") + 3]

textiva = str(iva)
textiva = textiva[:textiva.find(".") + 3]

texttotal = str(total)
texttotal = texttotal[:texttotal.find(".") + 3]

print()
print("factura".upper().center(80, "-"))
print(art1.title().ljust(73,".")+str(precioart1).zfill(6)+"€")
print(art2.title().ljust(73,".")+str(precioart2).zfill(6)+"€")
print(art3.title().ljust(73,".")+str(precioart3).zfill(6)+"€")
print("".center(80,"-"))
print("Precio base: ".upper().rjust(73) + textpreciobase.zfill(6) + "€")
print("iva: ".upper().rjust(73) + textiva.zfill(6) +"€")
print("total a pagar: ".upper().rjust(73) + texttotal.zfill(6) + "€")
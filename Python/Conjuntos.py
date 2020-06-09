Calabria = set({"Catanzaro", "Cosenza", "Crotona", "Reggio de Calabria", "Vibo Valentia"})
Campania = set({"Avellino", "Benevento", "Caserta", "Napoli", "Salerno"})
Lacio = set({"Frosinone", "Latina", "Rieti", "Roma", "Viterbo"})
Liguria = set({"Genova", "Imperia", "La Spezia", "Savona"})
Lucania = set({"Matera", "Potenza"})
Molise = set({"Campobasso", "Isernia"})
Toscana = set({"Arezzo", "Florencia", "Grosseto", "Livorno", "Lucca", "Massa-Carrara", "Pisa", "Pistoia", "Prato", "Siena"})
Umbria = set({"Perusa", "Terni"})
Veneto = set({"Belluno", "Padua", "Rovigo", "Treviso", "Venecia", "Verona", "Vicenza"})

Regiones = (Calabria, "Calabria", Campania, "Campania", Lacio, "Lacio", Liguria, "Liguria", Lucania, "Lucania", Molise, "Molise", Toscana, "Toscana", Pistoia, "Pistoia", Umbria, "Umbria", Veneto, "Veneto")


def BuscaProvincia(Region):
    if provincia in Region:
        return True
    else:
        return False

def conjuntoItalia(region):
    region.remove(provincia)
    print("\nSus provincias son (excepto la que ha indicado):")
    for reg in region:
        print(nombre.ljust(20), end="")
    Italia = set()
    Italia.update(Calabria, Campania, Lacio, Liguria, Lucania, Molise, Toscana, Pistoia, Umbria, Veneto)
    print("\n\nLas provincias de Italia en conjunto son:")
    for reg in Italia:
        print(nombre.ljust(20), end="")

provincia = input("\nEscriba la provincia italiana: ")
Region = ""
cont = 0
while cont < len(Regiones):
    if BuscaProvincia(Regiones[cont]):
        Region = Regiones[cont]
        nombreRegion = Regiones[cont + 1]
    cont += 2
if Region == "":
    print("\nLa provincia " + provincia + "no existe.")
else:
    print("\nLa Región de " + provincia + " es " + nombreRegion)
    conjuntoItalia(Region)
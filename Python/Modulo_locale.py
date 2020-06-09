import locale

def imprime(cantidad):
    print("\nUna cantidad monetaria con símbolo local:", locale.currency(cantidad, symbol=True, grouping=True))
    print("La misma cantidad con símbolo internacional:", locale.currency(cantidad, symbol=True, grouping=True, international=True))

locale.setlocale(locale.LC_ALL, '')
print("El código de lenguaje y codificacion local es", locale.getdefaultlocale())
imprime(45640.3645)

japon = locale.normalize("ja")
print("\nCódigo de configuración regional de Japón normalizado:", japon)
japon = japon[:japon.find(".")]
print("Código de configuración regional sin codificación:", japon)
locale.setlocale(locale.LC_ALL, japon)
imprime(45640.3645)
    
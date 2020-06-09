from clases.convertidor import *

print("Establecemos el cambio Euro-Dolar en 1.11")
cambiador = convertidor(1.11)
print("Indicamos una cantidad impuesta de 150 euros")
cambiador.cantidad_euros(150)
print("# Cantidad en Euros: ", cambiador.muestra_euros())
print("# Cantidad en Dólares: ", cambiador.muestra_dolares())
print("Indicamos una cantidad impuesta de 250 Dólares")
cambiador.cantidad_dolares(250)
print("# Cantidad en Euros: ", cambiador.muestra_euros())
print("# Cantidad en Dólares: ", cambiador.muestra_dolares())

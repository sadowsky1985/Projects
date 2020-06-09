def suma(num1, num2):    
    return num1 + num2

def resta(num1, num2):
    return num1 - num2

palabra=""

while palabra != "salir":
    palabra = input("Indique la operación Matemática ( suma - resta ) o salir: ")
    if palabra in globals():
        if callable(globals()[palabra]):
            num1 = eval(input("Dime el primer número: "))
            num2 = eval(input("Dime el primer número: "))
            resul = (globals()[palabra](num1, num2))
            print("La " + palabra + " es " + str(resul))
    else:
        if palabra != "salir":
            print("La palabra " + palabra + " no existe.")   
print("Gracias por usar la calculadora.")              



def Factorial(num=10):
    if num > 1:
        return num * Factorial(num -1)
    else:
        return 1
print("El factorial de 3 es: " +str(Factorial(3)))
print("El factorial de 5 es: " +str(Factorial(5)))
print("El factorial de 8 es: " + str(Factorial(8)))
print("El factorial del valor por defecto (10) es "+ str(Factorial()))
        

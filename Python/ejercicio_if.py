jugador1="piedra"
jugador2="papel"
if jugador1==jugador2:
    resultado="es empate."
elif jugador1=="piedra" and jugador2=="tijeras":
    resultado="gano yo."
elif jugador1=="piedra" and jugador2=="papel":
    resultado="ganas tú."
print("Mi jugada es "+jugador1+" y tu jugada es "+jugador2+", por lo tanto "+resultado)
    
    
jugador1="piedra"
jugador2="papel"
if jugador1==jugador2:
    resultado="es empate."
elif jugador1=="piedra":
    resultado="gano yo." if jugador2=="tijeras" else "pierdo."
elif jugador1=="papel":
    resultado="gano yo." if jugador2=="piedra" else "pierdo."
else:
    resultado="gano yo." if jugador2=="papel" else "pierdo."

print("Mi jugada es "+jugador1+" y tu jugada es "+jugador2+", por lo tanto "+resultado)


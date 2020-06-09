from tierra.moto import tienemotor
import tierra.bicicleta as bici
import mar.petrolero as barco
import aire.parapente
from aire.helicoptero import despegue as despegueheli

print("bicicleta: ¿Cuántas ruedas?", bici.ruedas())

# la función tienemotor es del espacio de nombres tierra.moto
print("moto: ¿Tiene motor?", tienemotor)

print("petrolero: ¿Qué tipos hay?", barco.tipos())

print("parapente: ¿Cómo despega?", aire.parapente.despegue())

print("helicóptero: ¿Cómo despega?", despegueheli())
import json


socios = {
"socios": [
  {"num socio": "0000",
   "nombre": "Socio Primero",
   "compras": [
     {"codigo": "0000",
      "cantidad": 0}
     ]
   }
  ]
}


archivo = open("json_socios.json", "w")
json.dump(socios, archivo, ensure_ascii=False, indent=2)
archivo.close()
print("Se ha generado el archivo json_socios.json de esta manera:\n", socios)

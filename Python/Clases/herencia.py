class Persona:
    def __init__(self, miNIF, minombre, misapellidos):
        self.NIF = miNIF
        self.nombre = minombre
        self.apellidos = misapellidos

    def __str__(self):
        return self.NIF + ": " + self.apellidos + ", " + self.nombre

class Alumno(Persona):
    def __init__(self, miNIF, minombre, misapellidos, micurso):
        super(Alumno, self).__init__(miNIF, minombre, misapellidos)
        self.curso = micurso

    def __str__(self):
        return self.NIF + ": " + self.apellidos + ", " + self.nombre + " (curso: " + self.curso + ")"

per1 = Persona("34799461R", "Susana", "Raval")
print(per1)
alum1 = Alumno("46588499T", "Francisco", "Ceballos", "Phyton")
print(alum1)

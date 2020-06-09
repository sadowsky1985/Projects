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
        self.disponible = Disponibilidad().curso(micurso)

    def __str__(self):
        return self.NIF + ": " + self.apellidos + ", " + self.nombre + " (curso: " + self.curso + ")"


class Disponibilidad:
    def __init__(self):
        self.cursos = ["C++", "Java", "Python", "SQL"]

    def curso(self, micurso):
        return micurso in self.cursos # Si está, devuelve True, encaso contrario False


per1 = Persona("34799461R", "Susana", "Raval")
print(per1)
alum1 = Alumno("46588499T", "Francisco", "Ceballos", "Python")
print(alum1)
if alum1.disponible:
    print("El curso está disponible")
else:
    print("Lo sentimos, ese curso no está disponible")

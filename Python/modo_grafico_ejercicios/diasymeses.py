from tkinter import *

def ordenapalabras():
    dias = ("lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo")
    meses = ("enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre",
    "diciembre")
    existe = False
    for dia in dias:
        if dia.lower() == varnombre.get().lower():
            nombredia.set(nombredia.get() + "\n" + dia)
            varnombre.set("")
            existe = True
    if not existe:
        for mes in meses:
            if mes.lower() == varnombre.get().lower():
                nombremes.set(nombremes.get() + "\n" + mes)
                varnombre.set("")
                existe = True
    mensajerror.set("")
    if not existe:
        mensajerror.set("La palabra no existe.")


ventana = Tk()
ventana.title("Días y meses")
ventana.resizable(False, False)
ventana.geometry("640x480+150+150")

zonarriba = Frame(ventana, width=640, height=240, bg="lightblue")
zonarriba.pack(side=TOP, expand=True, fill=BOTH)
etiqueta1 = Label(zonarriba, text="Escriba el nombre: ", bg="yellow").pack(side=LEFT)
varnombre = StringVar()
cuadronombre = Entry(zonarriba, textvariable=varnombre, width=20).pack(side=LEFT)
botonintro = Button(zonarriba, text="Introducir", command=ordenapalabras).pack(side=RIGHT)
mensajerror = StringVar()
Label(zonarriba, bg="lightblue", textvariable=mensajerror).pack(side=BOTTOM)

zonabajo = Frame(ventana, width=20, height=50, bg="gray")
zonabajo.pack(side=BOTTOM, expand=True, fill=X)
nombredia = StringVar()
nombredia.set("DÍAS:")
Label(zonabajo, text="DÍAS:", bg="yellow", textvariable=nombredia).pack(side=LEFT)
nombremes = StringVar()
nombremes.set("MESES:")
Label(zonabajo, text="MESES:", bg="cyan", textvariable=nombremes).pack(side=RIGHT)

ventana.mainloop()
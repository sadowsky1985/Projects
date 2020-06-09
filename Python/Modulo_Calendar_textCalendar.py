import calendar

año = eval(input("Escribe un año: "))
mes = eval(input("Escribe un mes: "))

calendario = calendar.LocaleTextCalendar(locale = '')
print("El calendario del mes:\n", calendario.formatmonth(año, mes, 5, 3))
print("El calendario anual, en 2 filas:")
calendario.pryear(año, m=6)
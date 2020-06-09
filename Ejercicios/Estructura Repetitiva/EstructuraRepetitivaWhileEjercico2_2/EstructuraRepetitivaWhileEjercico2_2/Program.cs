using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, altura, suma, promedio;
            string linea;
            n = 1;
            x = 1;
            suma = 0;
            Console.Write("Cuántas alturas ingresarás?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
            Console.Write("Ingrese altura:");
            linea = Console.ReadLine();
            altura = int.Parse(linea);
            x = x + 1;
            suma = suma + altura;
            }
            promedio = suma / n;
            Console.Write("La altura promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}

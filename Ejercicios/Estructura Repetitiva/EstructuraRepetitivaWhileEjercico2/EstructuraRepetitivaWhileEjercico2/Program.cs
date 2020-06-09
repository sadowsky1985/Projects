using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, altura, suma, promedio;
            string linea;
            x = 1;
            Console.Write("Cuántas personas hay?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            suma = 0;
            while(x <= n)
            {
                Console.Write("Ingrese altura en centímetros:");
                linea = Console.ReadLine();
                altura = int.Parse(linea);
                suma = suma + altura;
                x = x + 1;

            }
            promedio = suma / n;
            Console.Write("El promedio de altura es:");
            Console.Write(promedio);
            Console.ReadKey();

        }
    }
}

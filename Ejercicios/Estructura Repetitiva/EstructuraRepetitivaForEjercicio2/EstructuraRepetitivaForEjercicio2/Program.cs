using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f, suma, numero;
            string linea;
            suma = 0;
            for (f=1; f<=10; f++)
            {
                Console.Write("Ingrese número:");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (f > 5)
                {
                    suma = suma + numero;
                }
                
            }
            Console.Write("La suma de últimos 5 números ingresados son:");
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}

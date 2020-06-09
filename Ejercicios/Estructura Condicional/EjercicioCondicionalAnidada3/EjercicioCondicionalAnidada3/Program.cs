using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicionalAnidada3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;
            Console.Write("Ingrese un número del 1 al 999:");
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            if (numero < 10)
            {
                Console.Write("Este número es de una cifra.");
            }
            else
            {
                if (numero < 100)
                {
                    Console.Write("Este número es de dos cifras.");
                }
                else
                {
                    if (numero < 1000)
                    {
                        Console.Write("Este número es de tres cifras.");
                    }
                    else
                    {
                        Console.Write("Número no válido. Máximo tres cifras.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

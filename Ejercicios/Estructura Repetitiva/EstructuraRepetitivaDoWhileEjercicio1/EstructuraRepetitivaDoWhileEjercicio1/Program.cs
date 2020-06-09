using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaDoWhileEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, valor;
            string linea;
            suma = 0;
            do
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 9999)
                {
                    suma = suma + valor;
                }
            } while (valor != 9999);
            Console.Write("El valor acumulado es:");
            Console.WriteLine(suma);
            if (suma > 0)
            {
                Console.Write("El valor es mayor a 0.");
            }
            else
            {
                if (suma < 0)
                {
                    Console.Write("El valor es menor a 0.");
                }
                else
                {
                    Console.Write("El valor es 0.");
                }
            }
            Console.ReadKey();
        }
    }
}

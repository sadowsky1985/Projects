using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, numValor, suma1, suma2;//HABIA CREADO EL DOBLE DE VARIABLES :(
            string linea;
            numValor = 1; //XQ ESTO ES UNO Y NO CERO?
            suma1 = 0;
            suma2 = 0;
            Console.WriteLine("PRIMERA LISTA:");
            while (numValor <= 3)
            {
                Console.Write("Ingrese un valor de la Lista 1:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                numValor = numValor + 1;
                suma1 = suma1 + valor;
            }
            Console.WriteLine("SEGUNDA LISTA:");
            numValor = 1; // NI IDEA XQ VA ESTO AQUI!
            while (numValor <= 3)
            {
                Console.Write("Ingrese un valor de la Lista 2:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                numValor = numValor + 1;
                suma2 = suma2 + valor;

            }

            if(suma1 > suma2)
            {
                Console.Write("La lista 1 es mayor.");
            }
            else
            {
                if(suma1 < suma2)
                {
                    Console.Write("Las lista 2 es mayor.");
                }
                else
                {
                    Console.Write("Las listas son iguales.");
                }
            }
            Console.ReadKey();
        }
    }
}

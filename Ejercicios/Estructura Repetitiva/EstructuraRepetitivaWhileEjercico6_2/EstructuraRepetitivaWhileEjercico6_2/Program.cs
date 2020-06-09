using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, valor1, valor2, acum1, acum2;
            string linea;
            x = 1;
            n = 1;
            acum1 = 0;
            acum2 = 0;
            Console.WriteLine("LISTA 1:");
            while (x <= 5)
            {

                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor1 = int.Parse(linea);
                x = x + 1;
                acum1 = acum1 + valor1;
            }
            Console.WriteLine("LISTA 2:");
            while (n <= 5)
            {

                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor2 = int.Parse(linea);
                n = n + 1;
                acum2 = acum2 + valor2;

            }

            if (acum1 == acum2)
            {
                Console.Write("Las listas son iguales");
            }
            else
            {

                if (acum1 > acum2)
                {
                    Console.Write("Lista 1 es mayor");
                }
                else
                {
                    Console.Write("Lista 2 es mayor");

                }
                
            }
            Console.ReadKey();
        
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicionalComp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;
            Console.Write("Ingrese número de una o dos cifras:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            if (num1 > 9)
            {
                Console.Write("Este número es de dos cifras");
            }  
            else
            {
                Console.Write("Este número es de una cifra");
            }

            Console.ReadKey();

        }
    }
}

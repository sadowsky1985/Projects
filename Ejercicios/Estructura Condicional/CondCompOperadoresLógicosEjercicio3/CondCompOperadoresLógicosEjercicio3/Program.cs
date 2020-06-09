using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.Write("Ingrese primer número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo número:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercero número:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.Write("Todos los números son menores a diez");

            }
            else
            {
                Console.Write("Algún número no es menor a 10.");
            }
            Console.ReadKey();


        }
    }
}

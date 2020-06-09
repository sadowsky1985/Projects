using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio4
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
            Console.Write("Ingrese tercer número:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.Write("Alguno de los número es menor a 10.");
            }
            else
            {
                Console.Write("Alguno de los números es mayor a 10.");
            }
            Console.ReadKey();
      
        }
    }
}

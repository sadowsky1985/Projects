using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, f, resultado;
            string linea;

            Console.Write("Ingrese un valor y se mostrará su tabla de multiplicar:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for(f=1; f<=12; f++)
            {
                resultado = n * f;
                Console.WriteLine(resultado);

            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, x, resultado;
            x = 5;
            for (f = 1; f <= 10; f++)
            {
                resultado = f * x;
                Console.WriteLine(resultado);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string linea;
            Console.Write("Ingrese la coordenada X:");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese la coordenada Y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
            if (x > 0 && y > 0)
            {
                Console.Write("Está en el primer cuadrante.");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("Está en el segundo cuadrante.");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("Está en el tercer cuadrante.");
                    }
                    else
                    {
                        Console.Write("Está en el cuarto cuadrante.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

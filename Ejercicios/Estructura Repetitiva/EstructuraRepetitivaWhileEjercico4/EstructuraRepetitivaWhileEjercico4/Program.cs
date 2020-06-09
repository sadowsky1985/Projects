using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTerminos, termino;
            nTerminos = 1;
            termino = 11;
            while (nTerminos <= 25)
            {
                Console.Write(termino);
                Console.Write("-");
                nTerminos = nTerminos + 1;
                termino = termino + 11;
            }

            Console.ReadKey();
        }
    }
}

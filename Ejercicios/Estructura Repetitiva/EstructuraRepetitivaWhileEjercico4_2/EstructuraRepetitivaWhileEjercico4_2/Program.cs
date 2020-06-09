using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, terminos;
            x = 1;
            terminos = 0;
            while (x <= 25)
            {

                Console.Write(terminos);
                Console.Write("-");
                terminos = terminos + 11;
                x = x + 1;

            }
            Console.ReadKey();
        }
    }
}

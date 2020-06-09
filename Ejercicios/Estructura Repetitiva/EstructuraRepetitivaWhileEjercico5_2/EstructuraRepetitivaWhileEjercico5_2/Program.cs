using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            
            valor = 8;
            while(valor <= 500)
            {
                Console.Write(valor);
                
                Console.Write("-");
                valor = valor + 8;
            }

            Console.ReadKey();
        }
    }
}

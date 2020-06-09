using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicionalAnidada2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;
            Console.Write("Ingrese un número:");
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            if (numero == 0)
            {
                Console.Write("Este número es Nulo");
            }
            else
            {
                if (numero > 1)
                {
                    Console.Write("Este número es positivo");
                }
                else
                {
                    Console.Write("Este número es negativo");
                }
                
            }
            Console.ReadKey();        
           
        }
    }
}

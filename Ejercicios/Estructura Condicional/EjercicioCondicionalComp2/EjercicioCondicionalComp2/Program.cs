using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, promedio;
            string linea;

            Console.Write("Ingrese la primera nota:");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese la segunda nota:");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese la tercera nota:");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7)
            {
                Console.Write("Promocionado");

            }
            else
            {
                Console.Write("No promocionado");
            }
                

            Console.ReadKey();
        }
    }
}

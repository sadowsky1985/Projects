using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicionalAnidada4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPreguntas, respCorrectas, nota;
            string linea;
            Console.Write("Ingrese el número de preguntas contestadas:");
            linea = Console.ReadLine();
            numPreguntas = int.Parse(linea);
            Console.Write("Ingrese número de respuestas correctas:");
            linea = Console.ReadLine();
            respCorrectas = int.Parse(linea);
            nota = respCorrectas * 100 / numPreguntas;
            if (nota < 50)
            {
                Console.Write("Fuera de Nivel");
            }
            else
            {
                if (nota <= 75)
                {
                    Console.Write("Nivel Regular");
                }
                else
                {
                    if (nota <= 90)
                    {
                        Console.Write("Nivel Medio");
                    }
                    else
                    {
                        Console.Write("Nivel Máximo");
                    }
                
                }
                
            }
            Console.ReadKey();
        }
    }
}

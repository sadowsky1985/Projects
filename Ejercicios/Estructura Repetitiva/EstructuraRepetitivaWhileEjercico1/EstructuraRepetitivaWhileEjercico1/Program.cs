using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, nota, notamayor7, notamenor7;
            string linea;
            x = 1;
            notamayor7 = 0;
            notamenor7 = 0;
            while (x <= 10)
            {
                Console.Write("Ingrese nota del alumno:");
                linea = Console.ReadLine();
                nota = int.Parse(linea);
                if (nota <=7)
                {
                    notamenor7 = notamenor7 + 1;
                }
                else
                {
                    notamayor7 = notamayor7 + 1;
                }
                x = x + 1;
            }
            Console.Write("Número de notas menores a 7:");
            Console.WriteLine(notamenor7);
            Console.Write("Número notas mayores a 7:");    
            Console.WriteLine(notamayor7);    
            Console.ReadKey();        
        }
    }
}

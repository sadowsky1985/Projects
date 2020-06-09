using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, z;//n=numero notas, X=valor de nota, Y=notas >=7,Z=nota<7.
            string linea;
            n = 1;
            y = 0;
            z = 0;
            while (n <= 10)
            {
                Console.Write("Ingrese nota:");
                linea = Console.ReadLine();
                x = int.Parse(linea);
                n = n + 1;
                if (x >= 7)
                {

                    y = y + 1;
                }
                else
                {
                   z = z + 1;
                }
                
            }
                
                Console.Write("Notas igual o mayores a 7:");
                Console.WriteLine(y);// xq va el line aqui
                Console.Write("Notas menores a 7:");
                Console.Write(z);
                Console.ReadKey();
            
            
        }
    }
}

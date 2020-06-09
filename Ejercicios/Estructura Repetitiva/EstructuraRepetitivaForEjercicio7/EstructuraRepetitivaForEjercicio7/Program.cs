using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, valor, f, multiplos15, positivos, negativos, pares;//N no hace falta xq sabes q pide 10 valors
            string linea;
            n = 10;
            positivos = 0;
            negativos = 0;
            multiplos15 = 0;
            pares = 0;
            for(f=1; f<=n; f++)//Aqui en vez de n es 10.
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if(valor < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }
                if(valor%15 == 0)
                {
                    multiplos15++;
                }
                if(valor%2 == 0)
                {
                    pares = pares + valor;
                }

            }
            Console.Write("Cantidad de valores negativos:");
            Console.WriteLine(negativos);
            Console.Write("Cantidad de valores positivos:");
            Console.WriteLine(positivos);
            Console.Write("Cantidad de múltiplos  de 15:");
            Console.WriteLine(multiplos15);
            Console.Write("Valor acumulado de los pares:");
            Console.WriteLine(pares);
            Console.ReadKey();
        }
    }
}

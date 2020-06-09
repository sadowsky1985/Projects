using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f, x, y, primer, segundo, tercer, cuarto;
            string linea;
            primer = 0;
            segundo = 0;
            tercer = 0;
            cuarto = 0;
            Console.Write("Cuántos puntos ingresará?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (f=1; f<=n; f++)
            {
                Console.Write("Ingrese coordenada X:");
                linea = Console.ReadLine();
                x = int.Parse(linea);
                Console.Write("Ingrese coordenada Y:");
                linea = Console.ReadLine();
                y = int.Parse(linea);
                if (x < 0 && y >= 0) // Habia puesto todo if ningun else!
                {
                    primer++;
                }
                else
                {
                    if (x >= 0 && y >= 0)
                    {
                        segundo++;
                    }
                    else
                    {
                        if (x < 0 && y < 0)
                        {
                            tercer++;
                        }
                        else
                        {
                            if (x >= 0 && y < 0)
                            {
                                cuarto++;
                            }
                        }
                    }    
                }
                
            }
            Console.Write("Número de puntos en primer cuadrante:");
            Console.WriteLine(primer);
            Console.Write("Número de puntos en segundo cuadrante:");
            Console.WriteLine(segundo);
            Console.Write("Número de puntos en tercer cuadrante:");
            Console.WriteLine(tercer);
            Console.Write("Número de puntos en cuarto cuadrante:");
            Console.WriteLine(cuarto);
            Console.ReadKey();
        }
    }
}

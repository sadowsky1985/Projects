using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, f, medidaBase, medidaAltura, superficie;//superficie=base*altura/2
            string linea;
            n = 1;
            x = 0;
            
            Console.Write("¿Cuántos triángulos va a ingresar?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for(f=1; f<=n; f++)
            {
                Console.Write("Ingrese la medida de la base:");
                linea = Console.ReadLine();
                medidaBase = int.Parse(linea);
                Console.Write("Ingrese medida de la altura:");
                linea = Console.ReadLine();
                medidaAltura = int.Parse(linea);

                Console.Write("La base es:");
                Console.WriteLine(medidaBase);
                Console.Write("La altura es:");
                Console.WriteLine(medidaAltura);
                superficie = medidaBase * medidaAltura / 2;
                Console.Write("La superficie es:");
                Console.WriteLine(superficie);
                
                if(superficie > 12)
                {
                    x = x + 1;
                }
                
            }
            Console.Write("Número de triángulos con superficie mayor a 12:");
            Console.Write(x);
            Console.ReadKey();
        }
    }
}

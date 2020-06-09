using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, edad, mañana, tarde, noche, promedio1, promedio2, promedio3;
            string linea;
            mañana = 0;
            tarde = 0;
            noche = 0;
            Console.WriteLine("TURNO DE MAÑANA:");
            for(f=1; f<=5; f++)
            {
                Console.Write("Ingrese edad del estudiante:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                mañana = mañana + edad;
            }
            promedio1 = mañana / 5;
            Console.Write("El promedio de edad en el turno de mañana es:");
            Console.WriteLine(promedio1);
            Console.WriteLine("TURNO DE TARDE:");
            for (f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese edad del estudiante:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                tarde = tarde + edad;
            }
            promedio2 = tarde / 5;
            Console.Write("El promedio de edad en el turno de tarde es:");
            Console.WriteLine(promedio2);
            Console.WriteLine("TURNO DE NOCHE:");
            for (f=1; f<=5; f++)
            {
                Console.Write("Ingrese edad del estudiante:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                noche = noche + edad;
            }
            promedio3 = noche / 5;
            Console.Write("El promedio de edad en el turno de noche es:");
            Console.WriteLine(promedio3);
            if(promedio1 > promedio2 && promedio1 > promedio3)
            {
                Console.Write("El turno de MAÑANA tienes un promedio de edad mayor");
            }
            else
            {
                if(promedio2 > promedio1 && promedio2 > promedio3)
                {
                    Console.Write("El turno de TARDE tienes un promedio de edad mayor");
                }
                else
                {
                    if(promedio3 > promedio1 && promedio3> promedio2)
                    {
                        Console.Write("El turno de NOCHE tiene un promedio de edad mayor");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

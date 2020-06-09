using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo, antiguedad;
            string linea;
            Console.Write("Ingrese sueldo del operario:");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
            Console.Write("Ingrese antigüedad del operario:");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
            if (sueldo < 500 && antiguedad >= 10)
            {
                int aumento20;
                aumento20 = sueldo * 20 / 100;
                Console.Write("Sueldo a pagar:");
                Console.Write(sueldo + aumento20);
            }
            else
            {
                int aumento5;
                aumento5 = sueldo * 5 / 100;
                if (sueldo < 500 && antiguedad < 10)
                {
                    Console.Write("Sueldo a pagar:");
                    Console.Write(sueldo + aumento5);
                }
                else
                {
                    Console.Write("Sueldo a pagar:");
                    Console.Write(sueldo);
                }

                           
            }
            Console.ReadKey();
        }
    }
}

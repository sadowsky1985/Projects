using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, x, sueldo, conta1, conta2, gasto;
            string linea;
            n = 1;
            x = 1;
            conta1 = 0;
            conta2 = 0;
            gasto = 0;
            Console.Write("Cuántos sueldos ingresá:");
            linea = Console.ReadLine();
            n = float.Parse(linea);
            while(x <= n)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                sueldo = float.Parse(linea);
                if(sueldo >= 300)
                {
                    conta1 = conta1 + 1;
                }
                else
                {
                    conta2 = conta2 + 1;
                }
                x = x + 1;
                gasto = gasto + sueldo;
            }
            Console.Write("Sueldos entre 100 y 300:");
            Console.WriteLine(conta2);
            Console.Write("Sueldos mayor a 300:");
            Console.WriteLine(conta1);
            Console.Write("El gasto en sueldos es:");
            
            Console.Write(gasto);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, valor, pares, impares;
            string linea;
            x = 1;

            
            pares = 0;
            impares = 0;
            Console.Write("Cuántos números va a ingresar?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                x = x + 1;
                
            
                if (valor % 2 == 0) //IF y ELSE van dentro de while!!!!
                {
                    pares = pares + 1;
                
                }
                else
                {
                    impares = impares + 1;
                
                }
            }
            Console.Write("Número de valores pares:");
            Console.WriteLine(pares);
            Console.Write("Número de valores impares:");
            Console.Write(impares);
            Console.ReadKey();
        }
    }
}

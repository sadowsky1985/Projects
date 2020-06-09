using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, valor, pares, impares;//QUÉ ES X?
            string linea;
            x = 1;//AQUÏ OTRA VEZ, le asigna valor 1
            pares = 0;
            impares = 0;
            Console.Write("¿Cuántos numeros ingresará?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.Write("Escriba el valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                x = x + 1;// AQUí de nuevo????   
            }
            Console.Write("Cantidad de números pares:");
            Console.WriteLine(pares);//Por qué el WriteLine solo aquí?
            Console.Write("Cantidad de números pares:");
            Console.Write(impares);
            Console.ReadKey();
        }
    }
}

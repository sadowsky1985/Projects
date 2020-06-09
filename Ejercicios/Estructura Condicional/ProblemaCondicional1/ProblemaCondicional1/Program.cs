using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, diferencia, producto, division;
            string linea;
            Console.Write("Introduzca primer número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Introduzca segundo número:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                suma = num1 + num2;
                Console.WriteLine(suma);
                diferencia = num1 - num2;
                Console.WriteLine(diferencia);


            }
            else
            {
                producto = num1 * num2;
                Console.WriteLine(producto);
                division = num1 / num2;
                Console.WriteLine(division);
                

            }
            Console.ReadKey();
            

        }
    }
}

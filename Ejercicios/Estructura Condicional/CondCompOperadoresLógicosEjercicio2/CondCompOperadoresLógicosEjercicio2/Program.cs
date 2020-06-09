using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, suma, producto;
            string linea;
            Console.Write("Introduzca el primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Introduzca el segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Introduzca el tercero valor:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 == num2 && num2 == num3)
            {
                Console.Write("La suma del primero y segunto:");
                suma = (num1 + num2);
                Console.WriteLine(suma);
                Console.Write("La suma del primero y del segundo multiplicado por el tercero:");
                producto = (suma * num3);
                Console.Write(producto);
            }
            Console.ReadKey();
        }

    }
}

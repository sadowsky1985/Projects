using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4;
            float suma, producto;
            string linea;
            Console.Write("Ingrese el primer número:");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Ingrese segundo número:");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);
            Console.Write("Ingrese tercer número:");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);
            Console.Write("Ingrese cuarto número:");
            linea = Console.ReadLine();
            num4 = float.Parse(linea);
            suma = num1 + num2;
            producto = num3 * num4;
            Console.Write("La suma de los dos primeros números es:");
            Console.WriteLine(suma);
            Console.Write("El producto de los ultimos números es:");
            Console.WriteLine(producto);
            Console.ReadKey();
            









        }
    }
}

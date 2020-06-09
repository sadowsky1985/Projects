using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuatroValoresSumaYPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, promedio;
            string linea;
            Console.Write("Escriba el primer número:");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Escriba el segundo número:");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);
            Console.Write("Escriba el tercer número:");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);
            Console.Write("Escriba el cuarto número:");
            linea = Console.ReadLine();
            num4 = float.Parse(linea);
            Console.Write("La suma de los cuatro números es:");
            suma = num1 + num2 + num3 + num4;
            Console.WriteLine(suma);
            Console.Write("El promedio de los cuatro números es:");
            promedio = suma / 4;
            Console.WriteLine(promedio);
            Console.ReadKey();



        }
    }
}

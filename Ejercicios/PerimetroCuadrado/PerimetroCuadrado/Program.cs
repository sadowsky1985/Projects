using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado, perimetro;
            string linea;
            Console.Write("¿Cuánto mide el lado del cuadrado?");
            linea = Console.ReadLine();
            
            perimetro = lado * 4;
            Console.Write("El perimetro del cuadrado es:");
            Console.WriteLine(perimetro);
            perimetro = float.Parse(linea);
            Console.ReadKey();







        }
    }
}

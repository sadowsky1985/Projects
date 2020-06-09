using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecioCantidadTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio, cantidad, total;
            string linea;
            Console.Write("Precio del artículo:");
            linea = Console.ReadLine();
            precio = float.Parse(linea);
            Console.Write("Cantidad de artículos:");
            linea = Console.ReadLine();
            cantidad = float.Parse(linea);
            Console.Write("Cantidad total a pagar:");
            total = precio * cantidad;
            Console.WriteLine(total);
            Console.ReadKey();
            



        }
    }
}

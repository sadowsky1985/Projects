using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo1
{
    class Program
    {

        static void Main(string[] args)

        {
            string nombre;
            Console.Write("¿Cómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola " + nombre);

            string apellido;
            Console.Write("¿Cómo te apellidas?");
            apellido = Console.ReadLine();
            Console.WriteLine($"Tu nombre completo es " + nombre + apellido);

            Console.ReadLine();

       
           }           

        

        
    }
}

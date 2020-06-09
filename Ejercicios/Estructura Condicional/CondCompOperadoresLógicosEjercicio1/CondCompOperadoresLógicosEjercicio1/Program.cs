using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes;
            string linea;
            Console.Write("Introduzca número del día:");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.Write("Introduzca número del mes:");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            if (dia == 25 && mes == 12)
            {
                Console.Write("¡Es Navidad!");
            }
            else
            {
                Console.Write("Aún no es Navidad, siga esperando.");

            }
            Console.ReadKey();

        }
    }
}

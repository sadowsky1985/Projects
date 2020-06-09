using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEjemplo1
{
    class PruebaVector1
    {
        private int[] sueldos;
        
        public void Cargar()
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese valor del componente:");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            for( int f = 0; f < 5; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            PruebaVector1 pv = new PruebaVector1();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}

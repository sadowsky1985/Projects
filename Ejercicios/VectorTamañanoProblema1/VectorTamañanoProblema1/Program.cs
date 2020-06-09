using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorTamañanoProblema1
{
    class VectorTamañoProblema1
    {
        private int[] vector1;

        public void Cargar()
        {
            Console.Write("Cuántos elementos cargará:");
            string linea;
            linea = Console.ReadLine();
            int cant = int.Parse(linea);
            vector1 = new int[cant];
            for (int f = 0; f < vector1.Length; f++)
            {
                Console.Write("Ingrese elemento:");
                linea = Console.ReadLine();
                vector1[f] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            for(int f=0; f < vector1.Length; f++)
            {
                Console.WriteLine(vector1[f]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorTamañoProblema1 vt = new VectorTamañoProblema1();
            vt.Cargar();
            vt.Imprimir();

        }
    }
}

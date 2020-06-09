using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProblema4
{
    class VectorProblema4
    {
        private int[] vector1;

        public void Cargar()
        {
            vector1 = new int[10];
            string linea;
            for (int f = 0; f < 10; f++)
            {
                Console.Write("Ingrese número:");
                linea = Console.ReadLine();
                vector1[f] = int.Parse(linea);
            }
        }  
        public void Ordenado()//ni idea de hacerlo :)
        {
            int orden = 1;
            for(int f=0; f<9; f++)
            {
                if (vector1[f + 1] < vector1[f])//no entiendo nada xD
                {
                    orden = 0;
                }
            }
            if (orden == 1)
            {
                Console.WriteLine("Está ordenado de menor a mayor");
            }
            else
            {
                Console.WriteLine("No está ordenado de menor a mayor");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorProblema4 vp = new VectorProblema4();
            vp.Cargar();
            vp.Ordenado();
        }
    }
}

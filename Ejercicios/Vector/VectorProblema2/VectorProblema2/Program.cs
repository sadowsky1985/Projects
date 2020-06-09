using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProblema2
{
    class VectorProblema2
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void Cargar()
        {
            string linea;
            vector1 = new int[4];// me dejo esto
            vector2 = new int[4];// y esto
            Console.WriteLine("PRIMER VECTOR");
            for(int f=0; f<4; f++)
            {
                Console.Write("Ingrese número:");
                linea = Console.ReadLine();
                vector1[f] = int.Parse(linea);
            }
            Console.WriteLine("SEGUNDO VECTOR");
            for (int f=0; f<4; f++)
            {
                Console.Write("Ingrese número:");
                linea = Console.ReadLine();
                vector2[f] = int.Parse(linea);
            }
        }
        public void SumaVectores()
        {
            vector3 = new int[4];
            for(int f=0; f < 4; f++)
            {
                vector3[f] = vector1[f] + vector2[f];
            }
            Console.WriteLine("VECTOR RESULTANTE");
            for(int f=0; f<4; f++)// no sabia hacer esto
            {
                Console.WriteLine(vector3[f]);
            }
            Console.ReadKey();
            
        }
        static void Main(string[] args)
        {
            VectorProblema2 vp = new VectorProblema2();
            vp.Cargar();
            vp.SumaVectores();

        }
    }
}

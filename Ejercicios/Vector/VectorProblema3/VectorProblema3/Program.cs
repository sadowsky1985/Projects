using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProblema3
{
    class VectorProblema3
    {
        private float[] cursoA;
        private float[] cursoB;

        public void Cargar()
        {
            string linea;
            cursoA = new float[5];
            cursoB = new float[5];
            Console.WriteLine("CURSO A.");
            for(int f=0; f<5; f++)
            {
                Console.Write("Ingrese nota:");
                linea = Console.ReadLine();
                cursoA[f] = float.Parse(linea);
            }
            Console.WriteLine("CURSO B.");
            for(int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese nota:");
                linea = Console.ReadLine();
                cursoB[f] = float.Parse(linea);
            }
        }
        public void Promedio()//no sabia como hacerlo
        {
            float suma1 = 0;
            float suma2 = 0;
            for(int f=0; f < 5; f++)
            {
                suma1 = suma1 + cursoA[f];
                suma2 = suma2 + cursoB[f];
            }
            float promedioA = suma1 / 5;
            float promedioB = suma2 / 5;
            Console.WriteLine("El promedio del curso A es:" + promedioA);//añadido esto por gusto
            Console.WriteLine("El promedio del curso B es:" + promedioB);
            if (promedioA > promedioB)
            {
                Console.WriteLine("El curso A tiene mayor promedio.");
            }
            else
            {
                Console.WriteLine("El curso B tiene mayor promedio.");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorProblema3 vp = new VectorProblema3();
            vp.Cargar();
            vp.Promedio();
        }
    }
}

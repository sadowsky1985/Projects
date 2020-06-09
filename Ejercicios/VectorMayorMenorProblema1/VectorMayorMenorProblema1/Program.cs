using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMayorMenorProblema1
{
    class VectorElementoMenor
    {
        private int[] vector;
        private int menor;//olvidado 

        public void Cargar()
        {
            
            Console.Write("Cuántos elementos cargará:");
            string linea = Console.ReadLine();
            int n = int.Parse(linea);//n es la cantidad de elemntos
            vector = new int[n];
            for(int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }
        public void Menor()
        {
            menor = vector[0];
            for (int f = 1; f < vector.Length; f++)
            {
                if (vector[f]< menor)
                {
                    menor = vector[f];
                }
            }
            Console.WriteLine("El elemento menor es:" + menor);
        }
        public void RepiteMenor()//ni idea
        {
            int cant = 0;
            for(int f = 0; f < vector.Length; f++)
            {
                if (vector[f] == menor)
                {
                    cant++;
                }
                if (cant > 1)
                {
                    Console.WriteLine("Se repite el menor en el vector.");
                }
                else
                {
                    Console.WriteLine("No se repite el menor en el vector.");
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            VectorElementoMenor vem = new VectorElementoMenor();
            vem.Cargar();
            vem.Menor();
            vem.RepiteMenor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorParaleloEjemplo1
{
    class VectorParalelo1
    {
        private string[] nombres;
        private int[] edades;

        public void Cargar()
        {
            nombres = new string[5];
            edades = new int[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre:");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese edad:");
                string linea;
                linea = Console.ReadLine();
                edades[f] = int.Parse(linea);
            }
        }
        public void MayoresEdad()
        {
            Console.WriteLine("Personas mayores de edad:");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edades[f] >= 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorParalelo1 vp = new VectorParalelo1();
            vp.Cargar();
            vp.MayoresEdad();
        }
    }
}

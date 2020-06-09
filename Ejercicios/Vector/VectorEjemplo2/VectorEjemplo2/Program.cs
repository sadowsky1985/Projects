using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEjemplo2
{
    class Alturas
    {
        private float[] alturas;
        private float promedio;

        public void Cargar()
        {
            alturas = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
        }
        public void CalcularPromedio()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + alturas[f];
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio de alturas:" + promedio);
        }
        public void MayoresMenores()
        {
            int may, men;
            may = 0;
            men = 0;
            for(int f = 0; f < 5; f++)
            {
                if (alturas[f] > promedio)
                {
                    may++;
                }
                else
                {
                    men++;
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:" + may);
            Console.WriteLine("Cantidad de personas menores al promedio:" + men);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Alturas alturas1 = new Alturas();
            alturas1.Cargar();
            alturas1.CalcularPromedio();
            alturas1.MayoresMenores();
        }
    }
}

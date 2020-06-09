using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProblema1
{
    class VectorProblemaElementos
    {
        private int[] elemento;

        public void Cargar()
        {
            elemento = new int[8];
            for(int f = 0; f < 8; f++)
            {
                string linea;
                Console.Write("Ingrese elemento:");
                linea = Console.ReadLine();
                elemento[f] = int.Parse(linea);
            }
        }
        public void Acumulado()
        {
            int suma = 0;
            for(int f = 0; f < 8; f++)
            {
                suma = suma + elemento[f];
            }
            Console.WriteLine("El valor acumulado de los elementos es:" + suma);

        }
        public void Mayor36()
        {
            float suma = 0;
            for (int f = 0; f < 8; f++)
            {


                if (elemento[f] > 36)
                {
                    suma = suma + elemento[f];
                }
            }
            Console.WriteLine("La suma de los elementos mayores a 36 es:" + suma);
        }
        public void Mayor50()
        {
            int cant = 0;
            for(int f = 0; f < 8; f++)
            {
                if (elemento[f] > 50)
                {
                    cant++;
                }
            }
            Console.WriteLine("La cantidad de valores mayores a 50 es:" + cant);
            Console.ReadKey();
        }
            
        static void Main(string[] args)
        {
            VectorProblemaElementos pe = new VectorProblemaElementos();
            pe.Cargar();
            pe.Acumulado();
            pe.Mayor36();
            pe.Mayor50();
        }
    }
}

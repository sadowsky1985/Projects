using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMayorMenorEjemplo1
{
    class VectorMayorMenor
    {
        private string[] nombres;
        private float[] sueldos;

        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre del empleado:");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese sueldo:");
                string linea = Console.ReadLine();
                sueldos[f] = float.Parse(linea);
            }
        }
        public void MayorSueldo()//ni idea
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for(int f = 1; f < nombres.Length; f++)//xq f=1? xq falta analizar del 1 al 4.(el 0 es pos)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es:" + nombres[pos]);
            Console.WriteLine("Tiene un sueldo de:" + mayor);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorMayorMenor vmm = new VectorMayorMenor();
            vmm.Cargar();
            vmm.MayorSueldo();
        }
    }
}

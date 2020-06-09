using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorTamañoEjemplo1
{
    class VectorTamañoEjemplo1
    {
        private int[] sueldos;

        public void Cargar()
        {
            Console.Write("Cuántos sueldos cargará:");
            string linea;
            linea=Console.ReadLine();
            int cant = int.Parse(linea);
            sueldos = new int[cant];
            for(int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            for(int f=0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            VectorTamañoEjemplo1 vt = new VectorTamañoEjemplo1();
            vt.Cargar();
            vt.Imprimir();
        }
    }
}

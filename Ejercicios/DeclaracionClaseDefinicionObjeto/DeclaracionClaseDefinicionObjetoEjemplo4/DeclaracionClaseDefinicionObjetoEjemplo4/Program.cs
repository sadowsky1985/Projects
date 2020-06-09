using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionClaseDefinicionObjetoEjemplo4
{
    class Cuadrado
    {
        private int lado;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese medida de lado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }
        public void ImprimirPerimetro()
        {
            int perimetro;
            perimetro = lado * 4;
            Console.WriteLine("El perímetro es:"+perimetro);
        }
        public void ImprimirSuperficie()
        {
            int superficie;
            superficie = lado * lado;
            Console.WriteLine("La superficie es:" + superficie);
        }
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Inicializar();
            cuadrado1.ImprimirPerimetro();
            cuadrado1.ImprimirSuperficie();
            Console.ReadKey();
        }
    }
}

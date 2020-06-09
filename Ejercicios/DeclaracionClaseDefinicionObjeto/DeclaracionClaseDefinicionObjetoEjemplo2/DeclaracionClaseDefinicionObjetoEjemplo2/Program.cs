using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionClaseDefinicionObjetoEjemplo2
{
    class Triangulo
    {
        private int lado1, lado2, lado3;
        
        public void Inicializar()
        {
            string linea;
            Console.Write("Medida lado 1:");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);
            Console.Write("Medida lado 2:");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);
            Console.Write("Medida lado 3:");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);
        }
        public void LadoMayor()
        {
            Console.Write("Lado mayor:");
            if(lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine(lado1);
            }
            else
            {
                if (lado2 > lado3)
                {
                    Console.WriteLine(lado2);
                }
                else
                {
                    Console.WriteLine(lado3);
                }
            }
        }
        public void EsEquilatero()
        {
            if(lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else
            {
                Console.WriteLine("El triángulo NO es equilátero.");
            }
        }
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.Inicializar();
            triangulo1.LadoMayor();
            triangulo1.EsEquilatero();
            Console.ReadKey();
        }
    }
}

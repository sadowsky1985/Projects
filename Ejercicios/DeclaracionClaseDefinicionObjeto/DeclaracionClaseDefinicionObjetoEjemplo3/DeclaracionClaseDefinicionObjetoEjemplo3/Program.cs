using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionClaseDefinicionObjetoEjemplo3
{
    class Punto
    {
        private int x, y;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese coordenada X:");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese coordenada Y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
                    
        }
        public void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.Write("El punto se encuentra en el PRIMER cuadrante.");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("El punto se encuentra en el SEGUNDO cuadrante.");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("El punto se encuentra en el TERCER cuadrante");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.Write("El punto se encuentra en el CUARTO cuadrante");
                        }
                        else
                        {
                            Console.Write("El punto no está en ningún cuadrante.");
                        }
                    }
                }
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Punto punto1 = new Punto();
            punto1.Inicializar();
            punto1.ImprimirCuadrante();
        }
    }
}

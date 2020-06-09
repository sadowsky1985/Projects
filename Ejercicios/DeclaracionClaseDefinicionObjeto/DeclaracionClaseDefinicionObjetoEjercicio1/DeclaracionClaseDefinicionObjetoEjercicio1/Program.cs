using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionClaseDefinicionObjetoEjercicio1
{
    class Empleado
    {   //aqui no sé xq no lleva private o public.
        string nombre;
        float sueldo;// Aqui es float, no int.

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese nombre de empleado:");
            nombre = Console.ReadLine();// aqui puse:linea=... y es nombre =...
            
            
            Console.Write("Ingrese sueldo de empleado:");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("El nombre del empleado es:" + nombre);
            Console.WriteLine("El sueldo del empleado es:" + sueldo);

        }
        public void ImprimirImpuestos()
        {
            if (sueldo > 3000)//si el sueldo es superior...no igual o superior
            {
                Console.Write("El empleado DEBE pagar impuestos.");
            }
            else
            {
                Console.Write("El empleado NO DEBE pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Inicializar();
            empleado1.ImprimirDatos();
            empleado1.ImprimirImpuestos();
            Console.ReadKey();
        }
    }
}

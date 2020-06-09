using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionClaseDefinicionObjetoEjercicio2
{
    class Operaciones
    {
        int x, y;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }
        public void Suma()
        {
            int suma;
            suma = x + y;
            Console.WriteLine("La suma de los valores es:" + suma);
        }
        public void Resta()
        {
            int resta;
            resta = x - y;
            Console.WriteLine("La resta de los valores es:" + resta);
        }
        public void Multiplicacion()
        {
            int multiplicacion;
            multiplicacion = x * y;
            Console.WriteLine("La multiplicación de los valores es:" + multiplicacion);
        }
        public void Division()
        {
            int division;
            division = x / y;
            Console.WriteLine("La división de los valores es:" + division);
        }

        static void Main(string[] args)
        {
            Operaciones operaciones1 = new Operaciones();
            operaciones1.Inicializar();
            operaciones1.Suma();
            operaciones1.Resta();
            operaciones1.Multiplicacion();
            operaciones1.Division();
            Console.ReadKey();


        }
    }
}

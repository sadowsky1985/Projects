using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;
            string aviso;
            Console.Write("Ingrese horas trabajadas:");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.Write("Ingrese pago por hora:");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            sueldo = horasTrabajadas * costoHora;
            Console.Write("El sueldo total es:");
            Console.Write(sueldo);
            Console.ReadKey();
            aviso = ("Pague lo antes posible!!");
            Console.WriteLine(aviso);
            

            Console.ReadKey();
           
        }
    }
}

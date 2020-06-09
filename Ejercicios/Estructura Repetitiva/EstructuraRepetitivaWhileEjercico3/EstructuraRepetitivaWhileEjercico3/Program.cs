using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhileEjercico3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmpleados, x; //x=contador numero empleados
            float sueldo, sueldoTotal;
            float sueldoMenor300, sueldoMayor300;
            string linea;
            x = 1;
            sueldoTotal = 0;
            sueldoMenor300 = 0;
            sueldoMayor300 = 0;
            Console.Write("Cuántos empleados tiene?:");
            linea = Console.ReadLine();
            numEmpleados = int.Parse(linea);
            while (x <= numEmpleados)
            {
                
                Console.Write("Cuánto cobra el empleado?:");
                linea = Console.ReadLine();
                sueldo = float.Parse(linea);
                x = x + 1;
                sueldoTotal = sueldoTotal + sueldo;
                if (sueldo > 300)
                {
                    sueldoMayor300 = sueldoMayor300 + 1;
                }
                else
                {                   
                    sueldoMenor300 = sueldoMenor300 + 1;
                }

            }
            
            Console.Write("El número de empleados que cobra más de 300 es:");
            Console.WriteLine(sueldoMayor300);
            Console.Write("El número de empleados que cobra menos de 300 es:");
            Console.WriteLine(sueldoMenor300);
            Console.Write("Gasto total en sueldos:");
            Console.WriteLine(sueldoTotal);
            Console.ReadKey();

       
        }
    }
}

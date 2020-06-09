using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicionalAnidada1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.Write("Ingrese el primer número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo número:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese el tercer número:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write(num1);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write(num2);
                }

                else
                {
                    Console.Write(num3);
                }


            }   

                
           
            Console.ReadKey();
        }
    }
}

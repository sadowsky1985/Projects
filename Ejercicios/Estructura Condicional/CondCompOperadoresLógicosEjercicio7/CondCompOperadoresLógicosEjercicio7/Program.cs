﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondCompOperadoresLógicosEjercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Rango de valores:");
            if (num1 < num2 && num1 < num3)
            {
                Console.Write(num1);
            }
            else
            {
                if (num2 < num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }

            }
            Console.Write("-");
            if (num1>num2 && num1 > num3)
            {
                Console.Write(num1);
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string linea;
            Console.Write("ingrese el sueldo:");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            if (sueldo > 3000)
            {
                Console.Write("Esta persona debe abonar impuestos");

            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaDoWhileEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCuenta;
            float saldo, suma;// me faltaba variable suma
            string linea;
            suma = 0;

            do
            {
                Console.Write("Ingrese número de cuenta:");
                linea = Console.ReadLine();
                numCuenta = int.Parse(linea);
                if (numCuenta >= 0)//habia puesto if mas abajo
                {
                    Console.Write("Ingrese saldo de cuenta:");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);
                    if (saldo > 0)
                    {
                        Console.WriteLine("Saldo Acreedor.");
                        suma = suma + saldo;// no entiendo
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Saldo Deudor.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo Nulo.");
                        }
                    }
                } 
            } while (numCuenta >= 0);
            Console.Write("Total saldos Acreedores:");
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}

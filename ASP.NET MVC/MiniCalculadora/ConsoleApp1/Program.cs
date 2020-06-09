using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MiniCalculadora
    {
        static void Main(string[] args)
        {
            string[] operadores = new string[] { "+", "-", "*", "/" };

            Console.WriteLine("Escribe el primer número:");
            string operando1 = Console.ReadLine();

            int numero1 = 0;
            if(!int.TryParse(operando1, out numero1))
            {
                Console.WriteLine("Número no válido. Escriba otro.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Escriba el tipo de operador:");
            string operador = Console.ReadLine();

            if (!operadores.Contains(operador))
            {
                string resultado = "Operación no soportada. Solo permitidos";

                foreach(string op in operadores)
                {
                    resultado += " " + op;
                }
                Console.WriteLine(resultado);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Escribe el segundo número");
            string operando2 = Console.ReadLine();

            int numero2 = 0;
            if (!int.TryParse(operando2, out numero2))
            {
                Console.WriteLine("Número no válido");
                Console.ReadLine();
                return;
            }
            if(operador == "+")
            {
                Console.WriteLine("El resultado es: " + (numero1 + numero2));
            }
            else if (operador == "-")
            {
                Console.WriteLine("El resultado es: " + (numero1 - numero2));
            }
            else if(operador == "*")
            {
                Console.WriteLine("El resultado es: " + (numero1 * numero2));
            }
            else if(operador == "/")
            {
                Console.WriteLine("El resultado es: " + (numero1 / numero2));
            }
            Console.ReadLine();
        }
    }
}

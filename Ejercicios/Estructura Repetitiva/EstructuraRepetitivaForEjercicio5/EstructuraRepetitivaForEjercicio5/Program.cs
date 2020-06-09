using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaForEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f, lado1, lado2, lado3, isosceles, equilatero, escaleno;
            string linea;
            Console.Write("Cuántos triángulos ingresará?:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            equilatero = 0;
            isosceles = 0;
            escaleno = 0;
            for(f=1; f<=n; f++)
            {
                Console.Write("ingrese lado 1 del triángulo:");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.Write("Ingrese lado 2 del triángulo:");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.Write("Ingrese lado 3 del triángulo:");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Es un triángulo equilatero");//aqui estaba el fallo puse (equilatero)
                    equilatero++;
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)//me faltaba el tercer ||
                    {
                       Console.WriteLine("Es un triángulo isósceles");//aqui igual
                        isosceles++;
                    }
                    else //aqui puse otro if
                    {
                        
                        Console.WriteLine("Es un triángulo escaleno");// y aqui
                        escaleno++;
                    }
                }
            }
                Console.Write("Cantidad de triángulos equilateros:");
                Console.WriteLine(equilatero);
                Console.Write("Cantidad de triángulos isósceles:");
                Console.WriteLine(isosceles);
                Console.Write("Cantidad de triángulos escalenos:");
                Console.WriteLine(escaleno);
                if(equilatero < isosceles && equilatero < escaleno)
                {
                    Console.Write("Hay menos triángulos equilateros");//mismofallo poniendo solo(equilatero)
                }
                else
                {
                    if(isosceles < equilatero || isosceles < escaleno)
                    {
                        Console.Write("hay menos triángulos isósceles");//mismo fallo(isosceles)
                    }
                    if(escaleno < isosceles || escaleno < equilatero)
                    {
                        Console.Write("Hay menos triángulos escalenos");//aqui(escaleno) 
                    }
                    if(equilatero == isosceles || equilatero == escaleno)
                    {
                    Console.Write("Hay el mismo número de triángulos");//Añadido por mi cuenta, no lo pide el ejercicio
                    }
                }
        Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMVC.Models
{
    public class Calculadora
    {
        private int a, b;

        private int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public Calculadora()
        {

        }
        public decimal suma(int a, int b)
        {
            int total = 0;
            total = a + b;
            return total;
        }
        public decimal resta(int a, int b)
        {
            int total = 0;
            total = a - b;
            return total;
        }
        public decimal multiplicacion(int a, int b)
        {
            int total = 0;
            total = a * b;
            return total;
        }
        public decimal division(int a, int b)
        {
            int total = 0;
            total = a / b;
            return total;
        }
    }
}
    public class Resultado
    {
        int Resultados;
    }
    
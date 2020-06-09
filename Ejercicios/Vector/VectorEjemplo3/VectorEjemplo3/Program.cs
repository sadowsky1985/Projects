using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEjemplo3
{
    class SueldosTurnos
    {
        private float[] turnoMañ;
        private float[] turnoTarde;

        public void Cargar()
        {
            string linea;
            turnoMañ = new float[4];
            turnoTarde = new float[4];
            Console.WriteLine("Sueldos de empleados del turno de la mañana.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                turnoMañ[f] = float.Parse(linea);
            }
            Console.WriteLine("Sueldos de empleados del turno de la tarde.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                turnoTarde[f] = float.Parse(linea);
            }
        }
        public void CalcularGastos()
        {
            float mañ = 0;
            float tar = 0;
            for(int f = 0; f < 4; f++)
            {
                mañ = mañ + turnoMañ[f];
                tar = tar + turnoTarde[f];
            }
            Console.WriteLine("Total de gastos del turno de la mañana:" + mañ);
            Console.WriteLine("Total de gastos del turno de la tarde:" + tar);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            SueldosTurnos st = new SueldosTurnos();
            st.Cargar();
            st.CalcularGastos();
        }
    }
}

using System;
using System.Diagnostics;
using System.IO;// añadido.
using System.ServiceProcess;

namespace EjerciciosServicios.ServicioDetector
{
    public partial class Detector : ServiceBase
    {
        public Detector()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Tiempo.Start();
        }

        protected override void OnStop()
        {
            Tiempo.Stop();
        }

        bool Activado = false;

        private void Anota(string Texto)
        {
            FileStream Archivo;
            StreamWriter Anotar;
            Archivo = new FileStream("C:\\Control Bloc de notas.txt", FileMode.Append);
            Anotar = new StreamWriter(Archivo);
            Anotar.WriteLine(Texto + DateTime.Now.ToString());
            Anotar.Close();
            Archivo.Close();
        }

        private void Tiempo_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Process[] Procesos;
            Tiempo.Enabled = false;
            Procesos = Process.GetProcessesByName("notepad");
            if (Procesos.Length == 0)// Ahora no está funcionando.
            {
                if (Activado)// si estaba fuuncionando, anotamos su detencion.
                {
                    Activado = false;
                    Anota("Detenido:");
                }
                else//Ahora si está funcionando
                {
                    if (!Activado)
                    {
                        Activado = true;
                        Anota("Iniciado:");
                    }
                }

                Tiempo.Enabled = true;


            }
        }
    }
}

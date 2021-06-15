using Clinica_Istea_program.Models;
using System;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClinicaDBContext.Cargar();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ingreso PantallaIngreso = new ingreso();
            gestionPersonal prueba = new gestionPersonal();
            prueba.Show();
            PantallaIngreso.Show();
            Application.Run();
        }
    }
}

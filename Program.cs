using Clinica_Istea_program.Models;
using System;
using System.Windows.Forms;
using System.Linq;


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

            //Especialidad e=ClinicaDBContext.Especialidades.Where(x => x.Nombre == "Cardiologia").FirstOrDefault();
            //detalleDepartamento d = new detalleDepartamento(e);
            //prueba.Show();
            //d.Show();
            PantallaIngreso.Show();
            Application.Run();
        }
    }
}

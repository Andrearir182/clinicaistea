using Clinica_Istea_program.Models;
using System;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class panelMenu : Form
    {

        public panelMenu()
        {
            InitializeComponent();
            //GAW: Al comenzar esta pantalla Mostrar como dialogo el LOGIN:
            // Agregar una referencia al usuario actual en la base de datos
            // o como atributo publico en el form de ingreso para luego obtenerlo desde aca.

           //GAW:
           //ingreso ingreso = new ingreso();
           //DialogResult dr = ingreso.ShowDialog();
           //
           //
           //if (dr != DialogResult.OK)
           //{
           //    //GAW: El usuario decidio cancelar.
           //    Close();
           //}
        }
        private void linkLabelMiCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Aca llamamos a la gestion de cuentas.
        }
        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Aca ponemos en null el usuario Actual en base de datos y mostramos el dialogo de ingreso.
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            irGestionPersonal();
        }
        private void buttonEspecialidades_Click_1(object sender, EventArgs e)
        {
            irGestionEspecialidades();
        }
        private void buttonMateriales_Click(object sender, EventArgs e)
        {
            irGestionMateriales();
        }

        private void irGestionMateriales()
        {
            gestionMateriales gm = new gestionMateriales();
            gm.Show();
        }
        private void irGestionEspecialidades() {
            gestionEspecialidades ge = new gestionEspecialidades();
            ge.Show();
        }
        private void irGestionPersonal() {
            gestionPersonal gp = new gestionPersonal();
            gp.Show();
        }

    }

}

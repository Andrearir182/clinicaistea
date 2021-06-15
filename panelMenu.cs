using System;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class panelMenu : Form
    {
        public panelMenu()
        {
            InitializeComponent();

        }
        private void linkLabelMiCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

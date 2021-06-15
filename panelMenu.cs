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
        private void buttonEspecialidades_Click(object sender, EventArgs e)
        {

        }
        private void buttonEspecialidades_Click_1(object sender, EventArgs e)
        {

        }
        private void buttonMateriales_Click(object sender, EventArgs e)
        {
            //esta llamada deberia redireccionarse a pantalla Departamentos que falta crear
            //y luego a su vez Departamentos debe hacer esta llamada pasandole 
            //el  nombre de departamento como string
            gestionPersonal detalleD = new gestionPersonal();
            detalleD.Show();
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }

}

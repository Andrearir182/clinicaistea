using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class cambiarContra : Form
    {
        public cambiarContra()
        {
            InitializeComponent();
            Txtuser.Text = ClinicaDBContext.GetUsuarioActivo();
        }

        private void cambiarContraseña(object sender, EventArgs e)
        {
            if (Txtpass.Text == Txtpass2.Text)
            {
                ClinicaDBContext.CambiarContraseña(Txtuser.Text, Txtpass.Text);
                MessageBox.Show("La contraseña ha sido cambiada con exito");
                IrIngreso();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void IrIngreso()
        {
            ingreso ing = new ingreso();
            ing.Show();
            this.Close();
        }

    }
}

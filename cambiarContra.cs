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
        private void Txtpass_Enter(object sender, EventArgs e)
        {
            FormatTextPass();
        }
        private void Txtpass_Leave(object sender, EventArgs e)
        {
            FormatTextPass();
        }

        private void Txtpass2_Enter(object sender, EventArgs e)
        {
            FormatTextPass2();
        }
        private void Txtpass2_Leave(object sender, EventArgs e)
        {
            FormatTextPass2();
        }
        private void FormatTextPass()
        {
            if (Txtpass.Text == "")
            {
                Txtpass.UseSystemPasswordChar = false;
                Txtpass.Text = "Reingrese nueva contraseña";
                Txtpass.ForeColor = Color.Silver;
            }
        }

        private void FormatTextPass2()
        {
            if (Txtpass2.Text == "")
            {
                Txtpass2.UseSystemPasswordChar = false;
                Txtpass2.Text = "Ingrese nueva contraseña";
                Txtpass2.ForeColor = Color.Silver;
            }
        }


        private void Txtpass_KeyDown(object sender, EventArgs e)
        {
            if (Txtpass.Text == "Ingrese nueva contraseña")
            {
                Txtpass.Text = "";
                Txtpass.ForeColor = Color.LightGray;
                Txtpass.UseSystemPasswordChar = true;
            }
        }

        private void Txtpass2_KeyDown(object sender, EventArgs e)
        {
            if (Txtpass2.Text == "Reingrese nueva contraseña")
            {
                Txtpass2.Text = "";
                Txtpass2.ForeColor = Color.LightGray;
                Txtpass2.UseSystemPasswordChar = true;
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

using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Clinica_Istea_program
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }
        private void Txtuser_Enter(object sender, EventArgs e)
        {
            FormatTextUser();
        }
        private void Txtuser_Leave(object sender, EventArgs e)
        {
            FormatTextUser();
        }
        private void Txtpass_Enter(object sender, EventArgs e)
        {
            FormatTextPass();
        }
        private void Txtpass_Leave(object sender, EventArgs e)
        {
            FormatTextPass();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerificarUsuarioContraseña();
        }

        private void VerificarUsuarioContraseña()
        {
            if (ClinicaDBContext.ValidarUsuario(Txtuser.Text, Txtpass.Text))
            {
                IrPanelMenu();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrecto/s");
            }
        }

        private void IrPanelMenu()
        {
            panelMenu pm = new panelMenu();
            pm.Show();
            this.Close();
        }
        private void IrclaveRecup()
        {
            claveRecup cr = new claveRecup();
            cr.Show();
            this.Close();
        }

        private void LinkLabelClaveRecup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IrclaveRecup();
        }

        private void FormatTextUser()
        {
            if (Txtuser.Text == "")
            {
                Txtuser.Text = "Usuario";
                Txtuser.ForeColor = Color.Silver;
            }
        }
        private void FormatTextPass()
        {
            if (Txtpass.Text == "")
            {
                Txtpass.UseSystemPasswordChar = false;
                Txtpass.Text = "Contraseña";
                Txtpass.ForeColor = Color.Silver;//LightGray

            }
        }

        private void Txtuser_KeyDown(object sender, EventArgs e)
        {
            if (Txtuser.Text == "Usuario")
            {
                Txtuser.Text = "";
                Txtuser.ForeColor = Color.LightGray;
            }
        }

        private void Txtpass_KeyDown(object sender, EventArgs e)
        {
            if (Txtpass.Text == "Contraseña")
            {
                Txtpass.Text = "";
                Txtpass.ForeColor = Color.LightGray;
                Txtpass.UseSystemPasswordChar = true;
            }
        }

    }
}

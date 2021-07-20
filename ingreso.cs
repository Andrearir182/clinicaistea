using Clinica_Istea_program.Models;
using System;
using System.Windows.Forms;



namespace Clinica_Istea_program
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }




        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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





    }
}

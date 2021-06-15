using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class claveRecup : Form
    {
        public claveRecup()
        {
            InitializeComponent();
        }

        private void recuperacionClave(object sender, EventArgs e)
        {
            if (ClinicaDBContext.ExisteUsuario(Txtuser.Text))
            {
                if (ClinicaDBContext.ValidarPreguntaSecreta(Txtuser.Text, Txtquest.Text))
                {
                    IrcambiarContra();
                }
                else
                {
                    MessageBox.Show("Pregunta secreta incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe en el sistema");
            }
        }

        private void IrcambiarContra()
        {
            ClinicaDBContext.SetUsuarioActivo(Txtuser.Text);
            cambiarContra cc = new cambiarContra();
            cc.Show();
            this.Close();
        }

        private void Txtuser_Enter(object sender, EventArgs e)
        {
            FormatTextUser();
        }
        private void Txtuser_Leave(object sender, EventArgs e)
        {
            FormatTextUser();
        }
        private void Txtquest_Enter(object sender, EventArgs e)
        {
            FormateTextPass();
        }
        private void Txtquest_Leave(object sender, EventArgs e)
        {
            FormateTextPass();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormatTextUser()
        {
            if (Txtuser.Text == "")
            {
                Txtuser.Text = "Usuario";
                Txtuser.ForeColor = Color.Silver;
            }
        }
        private void FormateTextPass()
        {
            if (Txtquest.Text == "")
            {
                Txtquest.Text = "¿Cual es el nombre de su primera mascota?";
                Txtquest.ForeColor = Color.Silver;//LightGray
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

        private void Txtquest_KeyDown(object sender, EventArgs e)
        {
            if (Txtquest.Text == "¿Cual es el nombre de su primera mascota?")
            {
                Txtquest.Text = "";
                Txtquest.ForeColor = Color.LightGray;
            }
        }
    }
}

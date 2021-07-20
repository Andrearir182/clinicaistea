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


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


     
    }
}

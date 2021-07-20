using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class altaEspecialidad : Form
    {
        public altaEspecialidad()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionEspecialidades ge = new gestionEspecialidades();
            ge.Show();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void agregarEspecialidad(object sender, EventArgs e)
        {
            if(Txtnombre.Text != "") {
                    if (!ClinicaDBContext.existeEspecialidad(Txtnombre.Text)){
                        ClinicaDBContext.addEspecialidad(Txtnombre.Text, Txtdesc.Text);
                        MessageBox.Show("Especialidad agregada con exito");
                        this.Close();
                        gestionEspecialidades ge = new gestionEspecialidades();
                        ge.Show();
                }
                else{
                        MessageBox.Show("Error: La especialidad ya existe en el sistema");
                    }
            }else{
                MessageBox.Show("Por favor ingrese un nombre para la especialidad");
            }

        }
    }
}

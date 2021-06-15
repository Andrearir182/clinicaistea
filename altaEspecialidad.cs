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

        private void Txtmaterial_Enter(object sender, EventArgs e)
        {
            FormatTextnombre();
        }
        private void Txtmaterial_Leave(object sender, EventArgs e)
        {
            FormatTextnombre();
        }
        private void Txtcant_Enter(object sender, EventArgs e)
        {
            FormateTextdesc();
        }
        private void Txtcant_Leave(object sender, EventArgs e)
        {
            FormateTextdesc();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormatTextnombre()
        {
            if (Txtnombre.Text == "")
            {
                Txtnombre.Text = "Nombre";
                Txtnombre.ForeColor = Color.Silver;
            }
        }
        private void FormateTextdesc()
        {
            if (Txtdesc.Text == "")
            {
                Txtdesc.Text = "Descripcion";
                Txtdesc.ForeColor = Color.Silver;
            }
        }

        private void Txtnombre_KeyDown(object sender, EventArgs e)
        {
            if (Txtnombre.Text == "Nombre")
            {
                Txtnombre.Text = "";
                Txtnombre.ForeColor = Color.LightGray;
            }
        }

        private void Txtdesc_KeyDown(object sender, EventArgs e)
        {
            if (Txtdesc.Text == "Descripcion")
            {
                Txtdesc.Text = "";
                Txtdesc.ForeColor = Color.LightGray;
            }
        }

        private void agregarEspecialidad(object sender, EventArgs e)
        {
            if(Txtnombre.Text != "Nombre") {
                    if (!ClinicaDBContext.existeEspecialidad(Txtnombre.Text)){
                        ClinicaDBContext.addEspecialidad(Txtnombre.Text, Txtdesc.Text);
                        MessageBox.Show("Especialidad agregada con exito");
                        this.Close();
                    }else{
                        MessageBox.Show("Error: La especialidad ya existe en el sistema");
                    }
            }else{
                MessageBox.Show("Por favor ingrese un nombre para la especialidad");
            }
        }
    }
}

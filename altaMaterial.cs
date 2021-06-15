using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class altaMaterial : Form
    {
        public altaMaterial()
        {
            InitializeComponent();
        }

        private void recuperacionClave(object sender, EventArgs e)
        {

        }

        private void validarSoloNumeros(object sender, EventArgs e) {
            foreach (char c in Txtcant.Text) {
                if (!Char.IsNumber(c)) {
                    Txtcant.Text = "";
                }
            }
        }


        private void Txtmaterial_Enter(object sender, EventArgs e)
        {
            FormatTextUser();
        }
        private void Txtmaterial_Leave(object sender, EventArgs e)
        {
            FormatTextUser();
        }
        private void Txtcant_Enter(object sender, EventArgs e)
        {
            FormateTextPass();
        }
        private void Txtcant_Leave(object sender, EventArgs e)
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
            if (Txtprod.Text == "")
            {
                Txtprod.Text = "Producto";
                Txtprod.ForeColor = Color.Silver;
            }
        }
        private void FormateTextPass()
        {
            if (Txtcant.Text == "")
            {
                Txtcant.Text = "Cantidad";
                Txtcant.ForeColor = Color.Silver;//LightGray
            }
        }

        private void Txtmaterial_KeyDown(object sender, EventArgs e)
        {
            if (Txtprod.Text == "Producto")
            {
                Txtprod.Text = "";
                Txtprod.ForeColor = Color.LightGray;
            }
        }

        private void Txtcant_KeyDown(object sender, EventArgs e)
        {
            if (Txtcant.Text == "Cantidad")
            {
                Txtcant.Text = "";
                Txtcant.ForeColor = Color.LightGray;
            }
        }

        private void agregarMaterial(object sender, EventArgs e)
        {
            if(Txtprod.Text != "Producto") {
                int number=0;
                bool success = Int32.TryParse(Txtcant.Text, out number);
                if (success && number>0) { 
                    if (!ClinicaDBContext.existeMaterial(Txtprod.Text)  ) {
                        ClinicaDBContext.addMaterial("pruebita",Txtprod.Text,Int32.Parse(Txtcant.Text));
                        MessageBox.Show("Producto agregado con exito");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Error: El producto ya existe en el sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad debe ser mayor a 0");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para el producto");
            }

        }
   
    }
}

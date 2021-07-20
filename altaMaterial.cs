using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class altaMaterial : Form
    {
        public Especialidad esp { get; set; }
        public altaMaterial(Especialidad d)
        {
            InitializeComponent();
            esp = d;
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            detalleDepartamento d = new detalleDepartamento(esp);
            d.Show();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

  

        private void agregarMaterial(object sender, EventArgs e)
        {
            if(Txtprod.Text != "") {
                int number=0;
                bool success = Int32.TryParse(Txtcant.Text, out number);
                if (success && number>0) { 
                    if (!ClinicaDBContext.existeMaterial(Txtprod.Text, esp)  ) {
                        ClinicaDBContext.addMaterial(Txtprod.Text, Int32.Parse(Txtcant.Text), esp);
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

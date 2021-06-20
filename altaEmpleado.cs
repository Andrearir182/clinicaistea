using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace Clinica_Istea_program
{
    public partial class altaEmpleado : Form
    {
        public altaEmpleado()
        {
            InitializeComponent();

            //Tenias que usar combobox.DataSource y DisplayMember
            foreach (string s in ClinicaDBContext.Especialidades.Select(x=>x.Nombre).ToList())
            {
                comboBoxBuscar.Items.Add(s);
            }
            
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void agregarEmpleado(object sender, EventArgs e) {
            if(ClinicaDBContext.Empleados.Where(x=>x.Matricula== txtMatricula.Text || x.Dni == txtDNI.Text).Any()) {
                MessageBox.Show("El empleado ya existe en el sistema");
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Nombre debe contener un valor");
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Apellido debe contener un valor");
            }
            else if (txtMatricula.Text == "")
            {
                MessageBox.Show("Matricula debe contener un valor");
            }
            else if (txtDNI.Text == "")
            {
                MessageBox.Show("DNI debe contener un valor");
            }
            else
            { 
                Especialidad es = ClinicaDBContext.Especialidades.Where(x => x.Nombre == comboBoxBuscar.Text).FirstOrDefault();
                ClinicaDBContext.Empleados.Add(new Empleado()
                {
                    //Info Basica
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDNI.Text = txtDNI.Text,
                    Matricula = txtMatricula.Text,
                    //Contacto
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    //Especialidad
                    especialidad = es,
                    //Domicilio particular
                    Calle = txtCalle.Text,
                    Localidad = txtLocalidad.Text,
                    Provincia = txtProvincia.Text
                });
                MessageBox.Show("Empleado agregado con exito");
                this.Close();
            }
           
        }

        private void Txt_Format_Nombre(object sender, EventArgs e){Txt_Format(txtNombre, "Nombre");}
        private void Txt_Format_Apellido(object sender, EventArgs e) { Txt_Format(txtApellido, "Apellido"); }
        private void Txt_Format_Dni(object sender, EventArgs e) { Txt_Format(txtDNI, "DNI"); }
        private void Txt_Format_Matricula(object sender, EventArgs e) { Txt_Format(txtMatricula, "Matricula"); }
        private void Txt_Format_Telefono(object sender, EventArgs e) { Txt_Format(txtTelefono, "Telefono"); }
        private void Txt_Format_Email(object sender, EventArgs e) { Txt_Format(txtEmail, "Email"); }
        private void Txt_Format_Calle(object sender, EventArgs e) { Txt_Format(txtCalle, "Calle"); }
        private void Txt_Format_Localidad(object sender, EventArgs e) { Txt_Format(txtLocalidad, "Localidad"); }
        private void Txt_Format_Provincia(object sender, EventArgs e) { Txt_Format(txtProvincia, "Provincia"); }

        private void Txt_KeyDown_Nombre(object sender, EventArgs e) { Txt_KeyDown(txtNombre, "Nombre"); }
        private void Txt_KeyDown_Apellido(object sender, EventArgs e) { Txt_KeyDown(txtApellido, "Apellido"); }
        private void Txt_KeyDown_Dni(object sender, EventArgs e) { Txt_KeyDown(txtDNI, "DNI"); }
        private void Txt_KeyDown_Matricula(object sender, EventArgs e) { Txt_KeyDown(txtMatricula, "Matricula"); }
        private void Txt_KeyDown_Telefono(object sender, EventArgs e) { Txt_KeyDown(txtTelefono, "Telefono"); }
        private void Txt_KeyDown_Email(object sender, EventArgs e) { Txt_KeyDown(txtEmail, "Email"); }
        private void Txt_KeyDown_Calle(object sender, EventArgs e) { Txt_KeyDown(txtCalle, "Calle"); }
        private void Txt_KeyDown_Localidad(object sender, EventArgs e) { Txt_KeyDown(txtLocalidad, "Localidad"); }
        private void Txt_KeyDown_Provincia(object sender, EventArgs e) { Txt_KeyDown(txtProvincia, "Provincia"); }


        private void Txt_Format(Control c, string texto)
        {
            if (c.Text == "")
            {
                c.Text = texto;
                c.ForeColor = Color.Silver;
            }
        }
        private void Txt_KeyDown(Control c, string texto)
        {
            if (c.Text == texto)
            {
                c.Text = "";
                c.ForeColor = Color.LightGray;
            }
        }

    }
}

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
            foreach (string s in ClinicaDBContext.Especialidades.Select(x=>x.Nombre).ToList())
            {
                comboBoxBuscar.Items.Add(s);
            }
            
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionPersonal gp = new gestionPersonal();
            gp.Show();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void agregarEmpleado(object sender, EventArgs e) {
            if(ClinicaDBContext.Empleados.Where(x=>x.Matricula== txtMatricula.Text || x.Dni == txtDNI.Text).Any()) {
                MessageBox.Show("El empleado ya existe en el sistema");
            }
            if (txtNombre.Text == "" || txtNombre.Text=="")
            {
                MessageBox.Show("Nombre debe contener un valor");
            }
            else if (txtApellido.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Apellido debe contener un valor");
            }
            else if (txtMatricula.Text == "" || txtMatricula.Text == "")
            {
                MessageBox.Show("Matricula debe contener un valor");
            }
            else if (txtDNI.Text == "" || txtDNI.Text == "")
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
                gestionPersonal gp = new gestionPersonal();
                gp.Show();
            }
        }
        public static AutoCompleteStringCollection Autocomplete(string texto)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (Especialidad Esp in ClinicaDBContext.Especialidades.Where(x => x.Nombre.Contains(texto)).ToList())
            {
                coleccion.Add(Esp.Nombre);
            }
            return coleccion;
        }



    }
}

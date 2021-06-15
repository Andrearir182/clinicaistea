using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Clinica_Istea_program
{
    public partial class detalleEmpleado : Form
    {
        public detalleEmpleado(Empleado e)
        {
            InitializeComponent();
            //Info Basica
            lblNombre.Text = e.Nombre + ' ' + e.Apellido;
            lblDNI.Text = e.Dni;
            lblMatricula.Text = e.Matricula;
            //Contacto
            lblTelefono.Text = e.Telefono;
            lblEmail.Text = e.Email;
            //Especialidad
            lblEspecialidad.Text = e.especialidad.Nombre;
            lblDescripcion.Text = e.especialidad.Descripcion;
            //Domicilio particular
            lblCalle.Text = e.Calle;
            lblLocalidad.Text= e.Localidad;
            lblProvincia.Text= e.Provincia;
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

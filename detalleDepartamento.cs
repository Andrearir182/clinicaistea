using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class detalleDepartamento : Form
    {
        public Especialidad Dep { get; set; }

        public detalleDepartamento(string DepName)
        {

            InitializeComponent();
            Dep = new Especialidad() { Nombre = DepName };

            foreach (string s in ClinicaDBContext.GetMateriales()) { 
                comboBoxBuscar.Items.Add(s);
            }
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }
            //falta modificar el metodo "BuscarMaterialesDepartamento" para que busque por departamento
            foreach (Material m in ClinicaDBContext.BuscarMaterialesDepartamento("Pediatria"))
            {
                FlowLayoutPanel fp = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                    fp.Controls.Add(new TextBox(){
                        Text="Producto",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        Enabled = false,
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(89, 20),
                        TabIndex = 13

                    });
                    fp.Controls.Add(new TextBox() { 
                        Text = m.Producto,
                        Enabled = false,
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Location = new System.Drawing.Point(130, 12),
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Name = "TxtProducto",
                        Size = new System.Drawing.Size(89, 20),
                        TabIndex = 22
                    });
                    fp.Controls.Add(new TextBox(){
                        Text="Cantidad",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        Enabled = false,
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(89, 20),
                        TabIndex = 20
                    });
                    //falta hacer que funcione, actualmente no esta agregando el control NumericUpDown
                    fp.Controls.Add(new NumericUpDown() {
                        Name = "numericUpDownCant",
                        Size = new System.Drawing.Size(89, 23),
                        TabIndex = 21,
                        Minimum = 0,
                        Maximum = 999999999999999
                        //ValueChanged += new System.EventHandler(actualizarCantidad)
                    });
                    this.flowLayoutPanelDetalleDep.Controls.Add(fp);

            }
        }

        //Este metodo deberi invocarse en el "ValueChanged" de NumericUpDown que actualmente no lo agrega

        //private void actualizarCantidad(object sender, EventArgs e)
        //{
        //    ClinicaDBContext.actualizarCantidad(Dep, TxtProducto.Text, Convert.ToInt32(numericUpDownCant.Value));
        //}

        public static AutoCompleteStringCollection Autocomplete(string texto)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (Especialidad Dpto in ClinicaDBContext.BuscarDepartamento(texto))
            {
                coleccion.Add(Dpto.Nombre);
            }
            return coleccion;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoMaterial(object sender, EventArgs e)
        {
            altaMaterial n = new altaMaterial();
            n.Show();
        }
    }
}

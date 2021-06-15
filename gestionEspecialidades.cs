using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Clinica_Istea_program
{
    public partial class gestionEspecialidades : Form
    {
        public Especialidad Dep { get; set; }

        public gestionEspecialidades(string DepName)
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
            foreach (Empleado e in ClinicaDBContext.Empleados)
            {
                FlowLayoutPanel fp1 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                    fp1.Controls.Add(new TextBox(){
                        Text="Nombre",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        Enabled = false,
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(89, 20),
                        TabIndex = 13

                    });
                    fp1.Controls.Add(new TextBox() { 
                        Text = e.Nombre + ' ' + e.Apellido,
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
                    fp1.Controls.Add(new TextBox(){
                        Text="Matricula",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        Enabled = false,
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(89, 20),
                        TabIndex = 20
                    });
                    fp1.Controls.Add(new TextBox()
                    {
                        Text = e.Matricula,
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
                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);
                FlowLayoutPanel fp2 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                fp2.Controls.Add(new TextBox()
                {
                    Text = "DNI",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Enabled = false,
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20),
                    TabIndex = 13

                });
                fp2.Controls.Add(new TextBox()
                {
                    Text = e.Dni,
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

                Button b = new Button()
                {
                    Text = "Ver",
                    Name=e.Id.ToString(),
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73))))),
                    FlatAppearance ={
                        BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127))))),
                        MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
                        MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))))
                    },
                    Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Enabled = false,
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20),
                    TabIndex = 20
                };
                b.Click += new System.EventHandler(this.btnVer_Click);   //this.Click 
                fp2.Controls.Add(b);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp2);

            }

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Empleado x = ClinicaDBContext.getEmpleado(Convert.ToInt32(this.Name));
            detalleEmpleado n = new detalleEmpleado(x);
            n.Show();
        }

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

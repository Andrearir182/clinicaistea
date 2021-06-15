using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Clinica_Istea_program
{
    public partial class gestionPersonal : Form
    {
        public Especialidad Dep { get; set; }

        public gestionPersonal()
        {

            InitializeComponent();

            foreach (string s in ClinicaDBContext.Empleados.Select(x=>x.Nombre)) { 
                comboBoxBuscar.Items.Add(s);
            }
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }

            foreach (Empleado e in ClinicaDBContext.Empleados)
            {
                FlowLayoutPanel fp1 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(398, 20) };
                    fp1.Controls.Add(new Label(){
                        Text="Nombre",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(49, 20)

                    });
                    fp1.Controls.Add(new Label() { 
                        Text = e.Nombre + ' ' + e.Apellido,
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(119, 20)
                    });
                    fp1.Controls.Add(new Label()
                    {
                        Text="Matricula",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(59, 20)
                    });
                    fp1.Controls.Add(new Label()
                    {
                        Text = e.Matricula,
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2)
                    });
                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);
                FlowLayoutPanel fp2 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(398, 20) };
                    fp2.Controls.Add(new Label()
                    {
                        Text = "DNI",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(49, 20)
                    });
                    fp2.Controls.Add(new Label()
                    {
                        Text = e.Dni,
                        Enabled = true,
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(119, 20)
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
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(89, 20)
                    };
                    b.Click += btnVer_Click;
                fp2.Controls.Add(b);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp2);

                 void btnVer_Click(object sender, EventArgs e)
                {
                    //MessageBox.Show("asdasdas");
                    Empleado x = ClinicaDBContext.getEmpleado(Convert.ToInt32(b.Name));
                    detalleEmpleado n = new detalleEmpleado(x);
                    n.Show();
                }
            }

        }

        public static AutoCompleteStringCollection Autocomplete(string texto)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (Empleado Emp in ClinicaDBContext.Empleados.Where(x=>x.Nombre.Contains(texto)).ToList())
            {
                coleccion.Add(Emp.Nombre);
            }
            return coleccion;
        }

        private void recargarListado(object sender, EventArgs e)
        {
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }

            string Texto = comboBoxBuscar.Text.ToUpper();
            List<Empleado> EmpleadosSeleccionados = ClinicaDBContext.Empleados.Where(z => (z.Nombre != null && z.Nombre.ToUpper().Contains(Texto)) || (z.Apellido != null && z.Apellido.ToUpper().Contains(Texto)) || (z.Dni != null && z.Dni.ToUpper().Contains(Texto)) || (z.Matricula != null && z.Matricula.ToUpper().Contains(Texto))).ToList();
            foreach (Empleado x in EmpleadosSeleccionados)
            {
                FlowLayoutPanel fp1 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(398, 20) };
                fp1.Controls.Add(new Label()
                {
                    Text = "Nombre",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(49, 20)

                });
                fp1.Controls.Add(new Label()
                {
                    Text = x.Nombre + ' ' + x.Apellido,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(119, 20)
                });
                fp1.Controls.Add(new Label()
                {
                    Text = "Matricula",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(59, 20)
                });
                fp1.Controls.Add(new Label()
                {
                    Text = x.Matricula,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2)
                });
                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);
                FlowLayoutPanel fp2 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(398, 20) };
                fp2.Controls.Add(new Label()
                {
                    Text = "DNI",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(49, 20)
                });
                fp2.Controls.Add(new Label()
                {
                    Text = x.Dni,
                    Enabled = true,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(119, 20)
                });
                Button b = new Button()
                {
                    Text = "Ver",
                    Name = x.Id.ToString(),
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73))))),
                    FlatAppearance ={
                                    BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127))))),
                                    MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
                                    MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))))
                                },
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20)
                };
                b.Click += btnVer_Click;
                fp2.Controls.Add(b);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp2);

                void btnVer_Click(object sender, EventArgs e)
                {
                    Empleado x = ClinicaDBContext.getEmpleado(Convert.ToInt32(b.Name));
                    detalleEmpleado n = new detalleEmpleado(x);
                    n.Show();
                }
            }
        }


        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoEmpleado(object sender, EventArgs e)
        {
            altaEmpleado n = new altaEmpleado();
            n.Show();
        }

    }
}

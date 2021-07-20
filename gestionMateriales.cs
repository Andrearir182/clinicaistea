using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Clinica_Istea_program
{
    public partial class gestionMateriales : Form
    {

        public gestionMateriales()
        {

            InitializeComponent();

            foreach (string s in ClinicaDBContext.Especialidades.Select(x => x.Nombre).ToList()) { 
                comboBoxBuscar.Items.Add(s);
            }
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }

            foreach (Especialidad d in ClinicaDBContext.Especialidades)
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
                    Text = d.Nombre,
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
                    Name = d.Nombre,
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
                fp1.Controls.Add(b);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);

                void btnVer_Click(object sender, EventArgs e)
                {
                    Especialidad x = ClinicaDBContext.getEspecialidad(b.Name);
                    detalleDepartamento d = new detalleDepartamento(x);
                    d.Show();
                    this.Close();
                }
            }
        }
        private void recargarListado(object sender, EventArgs e)
        {
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }

            string Texto = comboBoxBuscar.Text.ToUpper();
            List<Especialidad> EspecialidadesSeleccion = ClinicaDBContext.Especialidades.Where(z => (z.Nombre != null && z.Nombre.ToUpper().Contains(Texto))).ToList();
            foreach (Especialidad d in EspecialidadesSeleccion)
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
                    Text = d.Nombre,
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
                    Name = d.Nombre,
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
                fp1.Controls.Add(b);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);

                void btnVer_Click(object sender, EventArgs e)
                {
                    Especialidad x = ClinicaDBContext.getEspecialidad(b.Name);
                    detalleDepartamento d = new detalleDepartamento(x);
                    d.Show();
                }
            }
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

        private void nuevoDepto(object sender, EventArgs e)
        {
            //nuevo departamento es lo mismo que nueva especialidad?
            altaEspecialidad n = new altaEspecialidad();
            n.Show();
        }
    }
}

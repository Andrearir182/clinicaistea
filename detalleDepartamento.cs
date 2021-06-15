using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Clinica_Istea_program
{
    public partial class detalleDepartamento : Form
    {
        public Especialidad esp { get; set; }
        public detalleDepartamento(Especialidad d)
        {
            InitializeComponent();
            esp = d;
            lblTitulo.Text = "DETALLE " + d.Nombre.ToUpper();
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }
            MessageBox.Show(d.Nombre);
            foreach (string s in ClinicaDBContext.GetMateriales(d)) { 
                comboBoxBuscar.Items.Add(s);
            }

            foreach (Material m in ClinicaDBContext.Materiales.Where(x=>x.Dep==d).ToList())
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
                    Text = m.Producto,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(119, 20)
                });
                fp1.Controls.Add(new Label()
                {
                    Text = "Cantidad",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(49, 20)
                });
                NumericUpDown b = new NumericUpDown()
                {
                    Text = "Ver",
                    Name = m.Producto,
                    Maximum= 999999999999999,
                    Minimum= 0,
                    Value = Convert.ToDecimal(m.Cantidad),
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73))))),
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20)
                };
                b.ValueChanged += ActualizarCant;
                fp1.Controls.Add(b);

                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);

                void ActualizarCant(object sender, EventArgs e)
                {
                    ClinicaDBContext.Materiales.Where(x => x.Producto == b.Name && x.Dep == d).FirstOrDefault().Cantidad=Convert.ToInt32(b.Value);
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
            List<Material> MaterialesSeleccionados = ClinicaDBContext.Materiales.Where(z => (z.Producto != null && z.Producto.ToUpper().Contains(Texto))).ToList();
            foreach (Material m in MaterialesSeleccionados)
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
                    Text = m.Producto,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(119, 20)
                });
                fp1.Controls.Add(new Label()
                {
                    Text = "Cantidad",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(49, 20)
                });
                NumericUpDown b = new NumericUpDown()
                {
                    Text = "Ver",
                    Name = m.Producto,
                    Maximum = 999999999999999,
                    Minimum = 0,
                    Value = Convert.ToDecimal(m.Cantidad),
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73))))),
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20)
                };
                b.ValueChanged += ActualizarCant;
                fp1.Controls.Add(b);

                this.flowLayoutPanelDetalleDep.Controls.Add(fp1);

                void ActualizarCant(object sender, EventArgs e)
                {
                    ClinicaDBContext.Materiales.Where(x => x.Producto == b.Name && x.Dep == esp).FirstOrDefault().Cantidad = Convert.ToInt32(b.Value);
                }
            }
        }
        
        public static AutoCompleteStringCollection Autocomplete(string texto)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (Material m in ClinicaDBContext.Materiales.Where(x => x.Producto.Contains(texto)).ToList())
            {
                coleccion.Add(m.Producto);
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

        private void nuevaEspecialidad(object sender, EventArgs e)
        {
            altaEspecialidad n = new altaEspecialidad();
            n.Show();
        }
    }
}

using Clinica_Istea_program.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Clinica_Istea_program
{
    public partial class gestionEspecialidades : Form
    {
        public Especialidad Dep { get; set; }

        public gestionEspecialidades()
        {

            InitializeComponent();

            foreach (string s in ClinicaDBContext.Especialidades.Select(x=>x.Nombre).ToList()) { 
                comboBoxBuscar.Items.Add(s);
            }
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }

            foreach (Especialidad es in ClinicaDBContext.Especialidades)
            {
                FlowLayoutPanel fp = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 60), BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D };
                
                FlowLayoutPanel fp1 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                    fp1.Controls.Add(new Label(){
                        Text="Nombre",
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Size = new System.Drawing.Size(90, 20),
                        TabIndex = 13

                    });
                    fp1.Controls.Add(new Label() { 
                        Text = es.Nombre,
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                        BorderStyle = System.Windows.Forms.BorderStyle.None,
                        Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Silver,
                        Location = new System.Drawing.Point(130, 12),
                        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                        Name = "TxtProducto",
                        Size = new System.Drawing.Size(89, 20),
                        TabIndex = 22
                    });

                FlowLayoutPanel fp2 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                fp2.Controls.Add(new Label()
                {
                    Text = "Descripcion",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20),
                    TabIndex = 20
                });
                fp2.Controls.Add(new Label()
                {
                    Text = es.Descripcion,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Location = new System.Drawing.Point(130, 12),
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Name = "TxtProducto",
                    Size = new System.Drawing.Size(250, 20),
                    TabIndex = 22
                });
                fp.Controls.Add(fp1);
                fp.Controls.Add(fp2);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp);
              
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

        private void recargarListado(object sender, EventArgs e)
        {
            while (this.flowLayoutPanelDetalleDep.Controls.Count > 0)
            {
                this.flowLayoutPanelDetalleDep.Controls.RemoveAt(0);
            }

            string Texto = comboBoxBuscar.Text.ToUpper();
            List<Especialidad> EspecialidadesSeleccion = ClinicaDBContext.Especialidades.Where(z => (z.Nombre != null && z.Nombre.ToUpper().Contains(Texto))).ToList();
            foreach (Especialidad es in EspecialidadesSeleccion)
            {
                FlowLayoutPanel fp = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 60), BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D };

                FlowLayoutPanel fp1 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                fp1.Controls.Add(new Label()
                {
                    Text = "Nombre",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(90, 20),
                    TabIndex = 13

                });
                fp1.Controls.Add(new Label()
                {
                    Text = es.Nombre,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Location = new System.Drawing.Point(130, 12),
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Name = "TxtProducto",
                    Size = new System.Drawing.Size(89, 20),
                    TabIndex = 22
                });

                FlowLayoutPanel fp2 = new FlowLayoutPanel() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight, Size = new System.Drawing.Size(378, 20) };
                fp2.Controls.Add(new Label()
                {
                    Text = "Descripcion",
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Size = new System.Drawing.Size(89, 20),
                    TabIndex = 20
                });
                fp2.Controls.Add(new Label()
                {
                    Text = es.Descripcion,
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80))))),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Silver,
                    Location = new System.Drawing.Point(130, 12),
                    Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                    Name = "TxtProducto",
                    Size = new System.Drawing.Size(250, 20),
                    TabIndex = 22
                });
                fp.Controls.Add(fp1);
                fp.Controls.Add(fp2);
                this.flowLayoutPanelDetalleDep.Controls.Add(fp);

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

        private void nuevaEspecialidad(object sender, EventArgs e)
        {
            altaEspecialidad n = new altaEspecialidad();
            n.Show();
            this.Close();
        }



        private void loadCSV_Click(object sender, EventArgs e)
        {
            string path = @"C:\CSVEspecialidades.csv";
            if (File.Exists(path))
            {
                foreach (string x in File.ReadAllText(path).Split("\n"))
                {
                    ClinicaDBContext.addEspecialidad(x.Split(";")[0], x.Split(";")[1]);
                }
                MessageBox.Show("Datos cargados con exito!");
            } else {
                MessageBox.Show(@"Debe cargar un archivo CSVEspecialdiades.csv en la ruta C:\ con formato nombre;descripcion");
            }
        }
    }
}

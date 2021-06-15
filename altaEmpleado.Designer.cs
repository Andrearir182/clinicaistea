
namespace Clinica_Istea_program
{
    partial class altaEmpleado

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altaEmpleado));
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(644, 2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(21, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(612, 2);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(24, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnMinimizar.TabIndex = 9;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Location = new System.Drawing.Point(59, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO BASICA";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.Color.Silver;
            this.txtApellido.Location = new System.Drawing.Point(9, 48);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(243, 20);
            this.txtApellido.TabIndex = 22;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.Click += new System.EventHandler(this.Txt_KeyDown_Apellido);
            this.txtApellido.Enter += new System.EventHandler(this.Txt_Format_Apellido);
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Apellido);
            this.txtApellido.Leave += new System.EventHandler(this.Txt_Format_Apellido);
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.ForeColor = System.Drawing.Color.Silver;
            this.txtMatricula.Location = new System.Drawing.Point(9, 99);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(243, 20);
            this.txtMatricula.TabIndex = 20;
            this.txtMatricula.Text = "Matricula";
            this.txtMatricula.Click += new System.EventHandler(this.Txt_KeyDown_Matricula);
            this.txtMatricula.Enter += new System.EventHandler(this.Txt_Format_Matricula);
            this.txtMatricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Matricula);
            this.txtMatricula.Leave += new System.EventHandler(this.Txt_Format_Matricula);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.ForeColor = System.Drawing.Color.Silver;
            this.txtDNI.Location = new System.Drawing.Point(9, 75);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(243, 20);
            this.txtDNI.TabIndex = 19;
            this.txtDNI.Text = "DNI";
            this.txtDNI.Click += new System.EventHandler(this.Txt_KeyDown_Dni);
            this.txtDNI.Enter += new System.EventHandler(this.Txt_Format_Dni);
            this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Dni);
            this.txtDNI.Leave += new System.EventHandler(this.Txt_Format_Dni);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(9, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.Txt_KeyDown_Nombre);
            this.txtNombre.Enter += new System.EventHandler(this.Txt_Format_Nombre);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Nombre);
            this.txtNombre.Leave += new System.EventHandler(this.Txt_Format_Nombre);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "______________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "______________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "______________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "______________________________";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Location = new System.Drawing.Point(59, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 83);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTACTO";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(9, 50);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 20);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.Txt_KeyDown_Email);
            this.txtEmail.Enter += new System.EventHandler(this.Txt_Format_Email);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Email);
            this.txtEmail.Leave += new System.EventHandler(this.Txt_Format_Email);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(9, 24);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 20);
            this.txtTelefono.TabIndex = 21;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Click += new System.EventHandler(this.Txt_KeyDown_Telefono);
            this.txtTelefono.Enter += new System.EventHandler(this.Txt_Format_Telefono);
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Telefono);
            this.txtTelefono.Leave += new System.EventHandler(this.Txt_Format_Telefono);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(4, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "______________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(5, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "______________________________";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtProvincia);
            this.groupBox3.Controls.Add(this.txtLocalidad);
            this.groupBox3.Controls.Add(this.txtCalle);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox3.Location = new System.Drawing.Point(347, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 107);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DOMICILIO PARTICULAR";
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProvincia.ForeColor = System.Drawing.Color.Silver;
            this.txtProvincia.Location = new System.Drawing.Point(6, 74);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(240, 20);
            this.txtProvincia.TabIndex = 26;
            this.txtProvincia.Text = "Provincia";
            this.txtProvincia.Click += new System.EventHandler(this.Txt_KeyDown_Provincia);
            this.txtProvincia.Enter += new System.EventHandler(this.Txt_Format_Provincia);
            this.txtProvincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Provincia);
            this.txtProvincia.Leave += new System.EventHandler(this.Txt_Format_Provincia);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocalidad.ForeColor = System.Drawing.Color.Silver;
            this.txtLocalidad.Location = new System.Drawing.Point(6, 48);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(240, 20);
            this.txtLocalidad.TabIndex = 25;
            this.txtLocalidad.Text = "Localidad";
            this.txtLocalidad.Click += new System.EventHandler(this.Txt_KeyDown_Localidad);
            this.txtLocalidad.Enter += new System.EventHandler(this.Txt_Format_Localidad);
            this.txtLocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Localidad);
            this.txtLocalidad.Leave += new System.EventHandler(this.Txt_Format_Localidad);
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalle.ForeColor = System.Drawing.Color.Silver;
            this.txtCalle.Location = new System.Drawing.Point(6, 24);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(240, 20);
            this.txtCalle.TabIndex = 24;
            this.txtCalle.Text = "Calle";
            this.txtCalle.Click += new System.EventHandler(this.Txt_KeyDown_Calle);
            this.txtCalle.Enter += new System.EventHandler(this.Txt_Format_Calle);
            this.txtCalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown_Calle);
            this.txtCalle.Leave += new System.EventHandler(this.Txt_Format_Calle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "______________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "______________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "______________________________";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxBuscar);
            this.groupBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox4.Location = new System.Drawing.Point(347, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 107);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ESPECIALIDAD";
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.AccessibleName = "";
            this.comboBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.comboBoxBuscar.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.IntegralHeight = false;
            this.comboBoxBuscar.Location = new System.Drawing.Point(6, 29);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(246, 26);
            this.comboBoxBuscar.TabIndex = 36;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(159, 275);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(357, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // altaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(675, 326);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "altaEmpleado";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
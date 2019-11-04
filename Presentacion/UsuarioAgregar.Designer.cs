namespace Presentacion
{
    partial class frmAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarUsuario));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpTareasHorarios = new System.Windows.Forms.GroupBox();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCodigoPostal = new System.Windows.Forms.ComboBox();
            this.dtpFnac = new System.Windows.Forms.DateTimePicker();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.grpUserPass = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpTareasHorarios.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.grpUserPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(481, 576);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 35);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(146, 576);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 35);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpTareasHorarios
            // 
            this.grpTareasHorarios.Controls.Add(this.cmbHorarios);
            this.grpTareasHorarios.Controls.Add(this.cmbPuesto);
            this.grpTareasHorarios.Controls.Add(this.label10);
            this.grpTareasHorarios.Controls.Add(this.label9);
            this.grpTareasHorarios.Location = new System.Drawing.Point(19, 364);
            this.grpTareasHorarios.Name = "grpTareasHorarios";
            this.grpTareasHorarios.Size = new System.Drawing.Size(757, 100);
            this.grpTareasHorarios.TabIndex = 43;
            this.grpTareasHorarios.TabStop = false;
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(222, 61);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(263, 28);
            this.cmbHorarios.TabIndex = 29;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(222, 24);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(263, 28);
            this.cmbPuesto.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(22, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Horario de trabajo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(22, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Puesto a desempeñar";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtMail);
            this.grpDatos.Controls.Add(this.lblMail);
            this.grpDatos.Controls.Add(this.grpSexo);
            this.grpDatos.Controls.Add(this.txtLocalidad);
            this.grpDatos.Controls.Add(this.lblSexo);
            this.grpDatos.Controls.Add(this.label14);
            this.grpDatos.Controls.Add(this.cmbCodigoPostal);
            this.grpDatos.Controls.Add(this.dtpFnac);
            this.grpDatos.Controls.Add(this.txtLegajo);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.lblLegajo);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtPais);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.txtDNI);
            this.grpDatos.Controls.Add(this.txtProvincia);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.ForeColor = System.Drawing.Color.Red;
            this.grpDatos.Location = new System.Drawing.Point(19, 22);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(10);
            this.grpDatos.MinimumSize = new System.Drawing.Size(757, 268);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(757, 329);
            this.grpDatos.TabIndex = 41;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(93, 246);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(642, 26);
            this.txtMail.TabIndex = 53;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(24, 246);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(44, 24);
            this.lblMail.TabIndex = 52;
            this.lblMail.Text = "Mail";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbHombre);
            this.grpSexo.Controls.Add(this.rdbMujer);
            this.grpSexo.Location = new System.Drawing.Point(459, 183);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(276, 48);
            this.grpSexo.TabIndex = 46;
            this.grpSexo.TabStop = false;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rdbHombre.ForeColor = System.Drawing.Color.Black;
            this.rdbHombre.Location = new System.Drawing.Point(36, 17);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(97, 28);
            this.rdbHombre.TabIndex = 51;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rdbMujer.ForeColor = System.Drawing.Color.Black;
            this.rdbMujer.Location = new System.Drawing.Point(178, 17);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(76, 28);
            this.rdbMujer.TabIndex = 52;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Location = new System.Drawing.Point(127, 159);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(239, 26);
            this.txtLocalidad.TabIndex = 49;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(391, 199);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 24);
            this.lblSexo.TabIndex = 47;
            this.lblSexo.Text = "Sexo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(24, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 24);
            this.label14.TabIndex = 48;
            this.label14.Text = "Localidad";
            // 
            // cmbCodigoPostal
            // 
            this.cmbCodigoPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoPostal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCodigoPostal.FormattingEnabled = true;
            this.cmbCodigoPostal.Location = new System.Drawing.Point(525, 114);
            this.cmbCodigoPostal.Name = "cmbCodigoPostal";
            this.cmbCodigoPostal.Size = new System.Drawing.Size(210, 28);
            this.cmbCodigoPostal.TabIndex = 46;
            this.cmbCodigoPostal.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoPostal_SelectedIndexChanged);
            // 
            // dtpFnac
            // 
            this.dtpFnac.Location = new System.Drawing.Point(346, 284);
            this.dtpFnac.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFnac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFnac.Name = "dtpFnac";
            this.dtpFnac.Size = new System.Drawing.Size(285, 26);
            this.dtpFnac.TabIndex = 21;
            this.dtpFnac.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtLegajo
            // 
            this.txtLegajo.AcceptsReturn = true;
            this.txtLegajo.AcceptsTab = true;
            this.txtLegajo.Location = new System.Drawing.Point(459, 33);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(276, 26);
            this.txtLegajo.TabIndex = 33;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(171, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLegajo.ForeColor = System.Drawing.Color.Black;
            this.lblLegajo.Location = new System.Drawing.Point(391, 34);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(67, 24);
            this.lblLegajo.TabIndex = 32;
            this.lblLegajo.Text = "Legajo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // txtPais
            // 
            this.txtPais.AcceptsReturn = true;
            this.txtPais.AcceptsTab = true;
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(67, 198);
            this.txtPais.MaxLength = 20;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(299, 26);
            this.txtPais.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(391, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(391, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Provincia";
            // 
            // txtDNI
            // 
            this.txtDNI.AcceptsReturn = true;
            this.txtDNI.AcceptsTab = true;
            this.txtDNI.Location = new System.Drawing.Point(93, 33);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(273, 26);
            this.txtDNI.TabIndex = 14;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtProvincia
            // 
            this.txtProvincia.AcceptsReturn = true;
            this.txtProvincia.AcceptsTab = true;
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Location = new System.Drawing.Point(484, 159);
            this.txtProvincia.MaxLength = 20;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(251, 26);
            this.txtProvincia.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.AcceptsReturn = true;
            this.txtApellido.AcceptsTab = true;
            this.txtApellido.Location = new System.Drawing.Point(109, 72);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(257, 26);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Location = new System.Drawing.Point(476, 72);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 26);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.AcceptsReturn = true;
            this.txtDireccion.AcceptsTab = true;
            this.txtDireccion.Location = new System.Drawing.Point(116, 115);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 26);
            this.txtDireccion.TabIndex = 18;
            // 
            // grpUserPass
            // 
            this.grpUserPass.Controls.Add(this.label12);
            this.grpUserPass.Controls.Add(this.label11);
            this.grpUserPass.Controls.Add(this.txtClave);
            this.grpUserPass.Controls.Add(this.txtUsuario);
            this.grpUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserPass.ForeColor = System.Drawing.Color.Red;
            this.grpUserPass.Location = new System.Drawing.Point(19, 480);
            this.grpUserPass.Name = "grpUserPass";
            this.grpUserPass.Size = new System.Drawing.Size(757, 81);
            this.grpUserPass.TabIndex = 42;
            this.grpUserPass.TabStop = false;
            this.grpUserPass.Text = "Usuario y Contraseña";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(368, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "Contraseña";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.AcceptsReturn = true;
            this.txtClave.AcceptsTab = true;
            this.txtClave.Location = new System.Drawing.Point(512, 35);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(200, 26);
            this.txtClave.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = true;
            this.txtUsuario.AcceptsTab = true;
            this.txtUsuario.Location = new System.Drawing.Point(135, 35);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(807, 636);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpTareasHorarios);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpUserPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(823, 674);
            this.MinimumSize = new System.Drawing.Size(823, 674);
            this.Name = "frmAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.grpTareasHorarios.ResumeLayout(false);
            this.grpTareasHorarios.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpUserPass.ResumeLayout(false);
            this.grpUserPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpTareasHorarios;
        public System.Windows.Forms.ComboBox cmbHorarios;
        public System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpDatos;
        public System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpFnac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.TextBox txtProvincia;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox grpUserPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtClave;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.ComboBox cmbCodigoPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox grpSexo;
        public System.Windows.Forms.RadioButton rdbHombre;
        public System.Windows.Forms.RadioButton rdbMujer;
        public System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
    }
}
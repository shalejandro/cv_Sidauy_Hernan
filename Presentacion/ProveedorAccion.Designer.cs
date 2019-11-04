namespace Presentacion
{
    partial class ProveedorAccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorAccion));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNumId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNumeroProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.cmbCodigoPostal = new System.Windows.Forms.ComboBox();
            this.dtpFnac = new System.Windows.Forms.DateTimePicker();
            this.lblInicioAct = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblNumId);
            this.grpDatos.Controls.Add(this.lblId);
            this.grpDatos.Controls.Add(this.txtNumeroProveedor);
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.txtMail);
            this.grpDatos.Controls.Add(this.lblMail);
            this.grpDatos.Controls.Add(this.cmbCodigoPostal);
            this.grpDatos.Controls.Add(this.dtpFnac);
            this.grpDatos.Controls.Add(this.lblInicioAct);
            this.grpDatos.Controls.Add(this.lblNro);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.txtCuit);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.ForeColor = System.Drawing.Color.Red;
            this.grpDatos.Location = new System.Drawing.Point(24, 29);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(10);
            this.grpDatos.MinimumSize = new System.Drawing.Size(757, 268);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(757, 268);
            this.grpDatos.TabIndex = 42;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblNumId
            // 
            this.lblNumId.AutoSize = true;
            this.lblNumId.ForeColor = System.Drawing.Color.Black;
            this.lblNumId.Location = new System.Drawing.Point(691, 36);
            this.lblNumId.Name = "lblNumId";
            this.lblNumId.Size = new System.Drawing.Size(51, 20);
            this.lblNumId.TabIndex = 59;
            this.lblNumId.Text = "label4";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(655, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 58;
            this.lblId.Text = "ID:";
            // 
            // txtNumeroProveedor
            // 
            this.txtNumeroProveedor.Location = new System.Drawing.Point(525, 33);
            this.txtNumeroProveedor.Name = "txtNumeroProveedor";
            this.txtNumeroProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumeroProveedor.Size = new System.Drawing.Size(124, 26);
            this.txtNumeroProveedor.TabIndex = 57;
            this.txtNumeroProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroProveedor_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(114, 156);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(252, 26);
            this.txtTelefono.TabIndex = 56;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroProveedor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(93, 197);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(642, 26);
            this.txtMail.TabIndex = 53;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(24, 196);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(44, 24);
            this.lblMail.TabIndex = 52;
            this.lblMail.Text = "Mail";
            // 
            // cmbCodigoPostal
            // 
            this.cmbCodigoPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoPostal.FormattingEnabled = true;
            this.cmbCodigoPostal.Location = new System.Drawing.Point(525, 118);
            this.cmbCodigoPostal.Name = "cmbCodigoPostal";
            this.cmbCodigoPostal.Size = new System.Drawing.Size(210, 28);
            this.cmbCodigoPostal.TabIndex = 46;
            // 
            // dtpFnac
            // 
            this.dtpFnac.Location = new System.Drawing.Point(511, 157);
            this.dtpFnac.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFnac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFnac.Name = "dtpFnac";
            this.dtpFnac.Size = new System.Drawing.Size(224, 26);
            this.dtpFnac.TabIndex = 21;
            this.dtpFnac.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblInicioAct
            // 
            this.lblInicioAct.AutoSize = true;
            this.lblInicioAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblInicioAct.ForeColor = System.Drawing.Color.Black;
            this.lblInicioAct.Location = new System.Drawing.Point(391, 159);
            this.lblInicioAct.Name = "lblInicioAct";
            this.lblInicioAct.Size = new System.Drawing.Size(91, 24);
            this.lblInicioAct.TabIndex = 9;
            this.lblInicioAct.Text = "Inicio Act.";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNro.ForeColor = System.Drawing.Color.Black;
            this.lblNro.Location = new System.Drawing.Point(391, 36);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(134, 24);
            this.lblNro.TabIndex = 32;
            this.lblNro.Text = "Nro.Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 77);
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
            this.label2.Location = new System.Drawing.Point(24, 76);
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
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "CUIT";
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(391, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo Postal";
            // 
            // txtCuit
            // 
            this.txtCuit.AcceptsReturn = true;
            this.txtCuit.AcceptsTab = true;
            this.txtCuit.Location = new System.Drawing.Point(93, 33);
            this.txtCuit.MaxLength = 20;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(273, 26);
            this.txtCuit.TabIndex = 14;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroProveedor_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.AcceptsReturn = true;
            this.txtApellido.AcceptsTab = true;
            this.txtApellido.Location = new System.Drawing.Point(109, 74);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(257, 26);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Location = new System.Drawing.Point(476, 75);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 26);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(485, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(178, 35);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnModificar.Location = new System.Drawing.Point(161, 324);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(178, 35);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(161, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(178, 35);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(161, 324);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(178, 35);
            this.btnBorrar.TabIndex = 48;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ProveedorAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 429);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 429);
            this.Name = "ProveedorAccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        public System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        public System.Windows.Forms.ComboBox cmbCodigoPostal;
        public System.Windows.Forms.DateTimePicker dtpFnac;
        private System.Windows.Forms.Label lblInicioAct;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCuit;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtNumeroProveedor;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblNumId;
    }
}
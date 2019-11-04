namespace Presentacion
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.cmbMozos = new System.Windows.Forms.ComboBox();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.btnHoy = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.GroupBox();
            this.chkMesa = new System.Windows.Forms.CheckBox();
            this.chkMozo = new System.Windows.Forms.CheckBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.chkEntre = new System.Windows.Forms.CheckBox();
            this.dtpEntre = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grpFecha = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.Fecha.SuspendLayout();
            this.grpFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.AllowUserToAddRows = false;
            this.dgvFacturacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFacturacion.Location = new System.Drawing.Point(27, 229);
            this.dgvFacturacion.MultiSelect = false;
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.RowHeadersVisible = false;
            this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacion.Size = new System.Drawing.Size(850, 302);
            this.dgvFacturacion.TabIndex = 2;
            this.dgvFacturacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturacion_CellDoubleClick);
            this.dgvFacturacion.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFacturacion_ColumnHeaderMouseClick);
            this.dgvFacturacion.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFacturacion_RowHeaderMouseClick);
            // 
            // cmbMozos
            // 
            this.cmbMozos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMozos.FormattingEnabled = true;
            this.cmbMozos.Location = new System.Drawing.Point(40, 65);
            this.cmbMozos.Name = "cmbMozos";
            this.cmbMozos.Size = new System.Drawing.Size(85, 21);
            this.cmbMozos.TabIndex = 9;
            this.cmbMozos.SelectedIndexChanged += new System.EventHandler(this.cmbMozos_SelectedIndexChanged);
            // 
            // cmbMesas
            // 
            this.cmbMesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesas.FormattingEnabled = true;
            this.cmbMesas.Location = new System.Drawing.Point(201, 65);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.Size = new System.Drawing.Size(85, 21);
            this.cmbMesas.TabIndex = 10;
            this.cmbMesas.SelectedIndexChanged += new System.EventHandler(this.cmbMesas_SelectedIndexChanged);
            // 
            // btnHoy
            // 
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.Location = new System.Drawing.Point(49, 69);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(86, 74);
            this.btnHoy.TabIndex = 2;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Controls.Add(this.chkMesa);
            this.Fecha.Controls.Add(this.chkMozo);
            this.Fecha.Controls.Add(this.cmbMesas);
            this.Fecha.Controls.Add(this.cmbMozos);
            this.Fecha.Location = new System.Drawing.Point(565, 46);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(312, 123);
            this.Fecha.TabIndex = 0;
            this.Fecha.TabStop = false;
            // 
            // chkMesa
            // 
            this.chkMesa.AutoSize = true;
            this.chkMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMesa.Location = new System.Drawing.Point(201, 34);
            this.chkMesa.Name = "chkMesa";
            this.chkMesa.Size = new System.Drawing.Size(65, 20);
            this.chkMesa.TabIndex = 20;
            this.chkMesa.Text = "Mesa";
            this.chkMesa.UseVisualStyleBackColor = true;
            this.chkMesa.CheckedChanged += new System.EventHandler(this.chkMesa_CheckedChanged);
            // 
            // chkMozo
            // 
            this.chkMozo.AutoSize = true;
            this.chkMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMozo.Location = new System.Drawing.Point(40, 34);
            this.chkMozo.Name = "chkMozo";
            this.chkMozo.Size = new System.Drawing.Size(64, 20);
            this.chkMozo.TabIndex = 19;
            this.chkMozo.Text = "Mozo";
            this.chkMozo.UseVisualStyleBackColor = true;
            this.chkMozo.CheckedChanged += new System.EventHandler(this.chkMozo_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFecha.Location = new System.Drawing.Point(74, 16);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(70, 20);
            this.chkFecha.TabIndex = 3;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(15, 84);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 13);
            this.lblHasta.TabIndex = 18;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(12, 50);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 13);
            this.lblDesde.TabIndex = 17;
            this.lblDesde.Text = "Desde";
            // 
            // chkEntre
            // 
            this.chkEntre.AutoSize = true;
            this.chkEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntre.Location = new System.Drawing.Point(267, 17);
            this.chkEntre.Name = "chkEntre";
            this.chkEntre.Size = new System.Drawing.Size(63, 20);
            this.chkEntre.TabIndex = 16;
            this.chkEntre.Text = "Entre";
            this.chkEntre.UseVisualStyleBackColor = true;
            this.chkEntre.CheckedChanged += new System.EventHandler(this.chkEntre_CheckedChanged);
            // 
            // dtpEntre
            // 
            this.dtpEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntre.Location = new System.Drawing.Point(74, 77);
            this.dtpEntre.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpEntre.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEntre.Name = "dtpEntre";
            this.dtpEntre.Size = new System.Drawing.Size(251, 22);
            this.dtpEntre.TabIndex = 15;
            this.dtpEntre.ValueChanged += new System.EventHandler(this.dtpEntre_ValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(74, 47);
            this.dtpFecha.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(251, 22);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // grpFecha
            // 
            this.grpFecha.BackColor = System.Drawing.Color.Transparent;
            this.grpFecha.Controls.Add(this.dtpEntre);
            this.grpFecha.Controls.Add(this.chkFecha);
            this.grpFecha.Controls.Add(this.chkEntre);
            this.grpFecha.Controls.Add(this.dtpFecha);
            this.grpFecha.Controls.Add(this.lblDesde);
            this.grpFecha.Controls.Add(this.lblHasta);
            this.grpFecha.Location = new System.Drawing.Point(177, 46);
            this.grpFecha.Name = "grpFecha";
            this.grpFecha.Size = new System.Drawing.Size(353, 123);
            this.grpFecha.TabIndex = 19;
            this.grpFecha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hacer Click sobre el item para ver detalle";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpFecha);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.btnHoy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.Fecha.ResumeLayout(false);
            this.Fecha.PerformLayout();
            this.grpFecha.ResumeLayout(false);
            this.grpFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.ComboBox cmbMozos;
        private System.Windows.Forms.ComboBox cmbMesas;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.GroupBox Fecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkEntre;
        private System.Windows.Forms.DateTimePicker dtpEntre;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.CheckBox chkMesa;
        private System.Windows.Forms.CheckBox chkMozo;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.GroupBox grpFecha;
        private System.Windows.Forms.Label label1;
    }
}
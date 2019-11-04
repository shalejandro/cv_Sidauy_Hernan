namespace Presentacion
{
    partial class frmAbm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proovedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProovedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoPostalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proovedoresToolStripMenuItem,
            this.accionesToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 29);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.AutoToolTip = true;
            this.accionesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.listarUsuariosToolStripMenuItem});
            this.accionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.accionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accionesToolStripMenuItem.Image")));
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.accionesToolStripMenuItem.Text = "&Usuarios";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.agregarToolStripMenuItem.Text = "&Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.borrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem.Image")));
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.borrarToolStripMenuItem.Text = "&Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // listarUsuariosToolStripMenuItem
            // 
            this.listarUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarUsuariosToolStripMenuItem.Image")));
            this.listarUsuariosToolStripMenuItem.Name = "listarUsuariosToolStripMenuItem";
            this.listarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.listarUsuariosToolStripMenuItem.Text = "&Listar Usuarios";
            this.listarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listarUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarçToolStripMenuItem,
            this.borrarToolStripMenuItem4,
            this.modificarToolStripMenuItem1,
            this.listaClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // agregarçToolStripMenuItem
            // 
            this.agregarçToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarçToolStripMenuItem.Image")));
            this.agregarçToolStripMenuItem.Name = "agregarçToolStripMenuItem";
            this.agregarçToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.agregarçToolStripMenuItem.Text = "&Agregar";
            this.agregarçToolStripMenuItem.Click += new System.EventHandler(this.agregarçToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem4
            // 
            this.borrarToolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem4.Image")));
            this.borrarToolStripMenuItem4.Name = "borrarToolStripMenuItem4";
            this.borrarToolStripMenuItem4.Size = new System.Drawing.Size(171, 26);
            this.borrarToolStripMenuItem4.Text = "&Borrar";
            this.borrarToolStripMenuItem4.Click += new System.EventHandler(this.borrarToolStripMenuItem4_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem1.Image")));
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.modificarToolStripMenuItem1.Text = "&Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaClientesToolStripMenuItem.Image")));
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.listaClientesToolStripMenuItem.Text = "&Lista Clientes";
            this.listaClientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientesToolStripMenuItem_Click);
            // 
            // proovedoresToolStripMenuItem
            // 
            this.proovedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem4,
            this.borrarToolStripMenuItem5,
            this.modificarToolStripMenuItem2,
            this.listaProovedoresToolStripMenuItem});
            this.proovedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.proovedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proovedoresToolStripMenuItem.Image")));
            this.proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            this.proovedoresToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.proovedoresToolStripMenuItem.Text = "&Proveedores";
            this.proovedoresToolStripMenuItem.Click += new System.EventHandler(this.proovedoresToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem4
            // 
            this.agregarToolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem4.Image")));
            this.agregarToolStripMenuItem4.Name = "agregarToolStripMenuItem4";
            this.agregarToolStripMenuItem4.Size = new System.Drawing.Size(203, 26);
            this.agregarToolStripMenuItem4.Text = "&Agregar";
            this.agregarToolStripMenuItem4.Click += new System.EventHandler(this.agregarToolStripMenuItem4_Click);
            // 
            // borrarToolStripMenuItem5
            // 
            this.borrarToolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem5.Image")));
            this.borrarToolStripMenuItem5.Name = "borrarToolStripMenuItem5";
            this.borrarToolStripMenuItem5.Size = new System.Drawing.Size(203, 26);
            this.borrarToolStripMenuItem5.Text = "&Borrar";
            this.borrarToolStripMenuItem5.Click += new System.EventHandler(this.borrarToolStripMenuItem5_Click);
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem2.Image")));
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(203, 26);
            this.modificarToolStripMenuItem2.Text = "&Modificar";
            this.modificarToolStripMenuItem2.Click += new System.EventHandler(this.modificarToolStripMenuItem2_Click);
            // 
            // listaProovedoresToolStripMenuItem
            // 
            this.listaProovedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProovedoresToolStripMenuItem.Image")));
            this.listaProovedoresToolStripMenuItem.Name = "listaProovedoresToolStripMenuItem";
            this.listaProovedoresToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.listaProovedoresToolStripMenuItem.Text = "&Lista Proveedores";
            this.listaProovedoresToolStripMenuItem.Click += new System.EventHandler(this.listaProovedoresToolStripMenuItem_Click);
            // 
            // accionesToolStripMenuItem1
            // 
            this.accionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoPostalToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.horarioToolStripMenuItem});
            this.accionesToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.accionesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("accionesToolStripMenuItem1.Image")));
            this.accionesToolStripMenuItem1.Name = "accionesToolStripMenuItem1";
            this.accionesToolStripMenuItem1.Size = new System.Drawing.Size(99, 25);
            this.accionesToolStripMenuItem1.Text = "&Acciones";
            // 
            // codigoPostalToolStripMenuItem
            // 
            this.codigoPostalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.borrarToolStripMenuItem3});
            this.codigoPostalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("codigoPostalToolStripMenuItem.Image")));
            this.codigoPostalToolStripMenuItem.Name = "codigoPostalToolStripMenuItem";
            this.codigoPostalToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.codigoPostalToolStripMenuItem.Text = "&Codigo Postal";
            this.codigoPostalToolStripMenuItem.Click += new System.EventHandler(this.codigoPostalToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem3.Image")));
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(136, 26);
            this.agregarToolStripMenuItem3.Text = "A&gregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click_1);
            // 
            // borrarToolStripMenuItem3
            // 
            this.borrarToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem3.Image")));
            this.borrarToolStripMenuItem3.Name = "borrarToolStripMenuItem3";
            this.borrarToolStripMenuItem3.Size = new System.Drawing.Size(136, 26);
            this.borrarToolStripMenuItem3.Text = "Borr&ar";
            this.borrarToolStripMenuItem3.Click += new System.EventHandler(this.borrarToolStripMenuItem3_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.puestoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("puestoToolStripMenuItem.Image")));
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.puestoToolStripMenuItem.Text = "&Puesto";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem1.Image")));
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem1.Image")));
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.borrarToolStripMenuItem2});
            this.horarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horarioToolStripMenuItem.Image")));
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.horarioToolStripMenuItem.Text = "&Horario";
            this.horarioToolStripMenuItem.Click += new System.EventHandler(this.horarioToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem2.Image")));
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.agregarToolStripMenuItem2.Text = "&Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // borrarToolStripMenuItem2
            // 
            this.borrarToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem2.Image")));
            this.borrarToolStripMenuItem2.Name = "borrarToolStripMenuItem2";
            this.borrarToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.borrarToolStripMenuItem2.Text = "&Borrar";
            this.borrarToolStripMenuItem2.Click += new System.EventHandler(this.borrarToolStripMenuItem2_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(698, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 16);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "Hora";
            // 
            // frmAbm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 619);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(841, 657);
            this.MinimumSize = new System.Drawing.Size(841, 657);
            this.Name = "frmAbm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas, Bajas y Modificaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem codigoPostalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proovedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaProovedoresToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem3;
    }
}
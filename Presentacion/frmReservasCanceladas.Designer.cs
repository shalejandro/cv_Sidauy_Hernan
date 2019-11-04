namespace Presentacion
{
    partial class frmReservasCanceladas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservasCanceladas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCanceladas = new System.Windows.Forms.DataGridView();
            this.dgvCancInasis = new System.Windows.Forms.DataGridView();
            this.dgvAsistio = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanceladas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancInasis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservas canceladas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservas Canceladas por Inasistencia";
            // 
            // dgvCanceladas
            // 
            this.dgvCanceladas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvCanceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanceladas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCanceladas.Location = new System.Drawing.Point(30, 39);
            this.dgvCanceladas.Name = "dgvCanceladas";
            this.dgvCanceladas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanceladas.Size = new System.Drawing.Size(636, 150);
            this.dgvCanceladas.TabIndex = 2;
            // 
            // dgvCancInasis
            // 
            this.dgvCancInasis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvCancInasis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancInasis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCancInasis.Location = new System.Drawing.Point(30, 266);
            this.dgvCancInasis.Name = "dgvCancInasis";
            this.dgvCancInasis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCancInasis.Size = new System.Drawing.Size(636, 150);
            this.dgvCancInasis.TabIndex = 3;
            this.dgvCancInasis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancInasis_CellContentClick);
            // 
            // dgvAsistio
            // 
            this.dgvAsistio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvAsistio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAsistio.Location = new System.Drawing.Point(31, 493);
            this.dgvAsistio.Name = "dgvAsistio";
            this.dgvAsistio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistio.Size = new System.Drawing.Size(636, 150);
            this.dgvAsistio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reservas Cumplidas";
            // 
            // frmReservasCanceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 659);
            this.Controls.Add(this.dgvAsistio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCancInasis);
            this.Controls.Add(this.dgvCanceladas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReservasCanceladas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas Canceladas";
            this.Load += new System.EventHandler(this.frmReservasCanceladas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanceladas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancInasis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCanceladas;
        private System.Windows.Forms.DataGridView dgvCancInasis;
        private System.Windows.Forms.DataGridView dgvAsistio;
        private System.Windows.Forms.Label label3;
    }
}
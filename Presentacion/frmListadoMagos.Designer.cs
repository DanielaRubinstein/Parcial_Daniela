namespace Presentacion
{
    partial class frmListadoMagos
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
            this.dgvMagos = new System.Windows.Forms.DataGridView();
            this.btnVerHechizos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMagos
            // 
            this.dgvMagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagos.Location = new System.Drawing.Point(12, 47);
            this.dgvMagos.Name = "dgvMagos";
            this.dgvMagos.RowTemplate.Height = 33;
            this.dgvMagos.Size = new System.Drawing.Size(1130, 672);
            this.dgvMagos.TabIndex = 0;
            this.dgvMagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagos_CellContentClick);
            // 
            // btnVerHechizos
            // 
            this.btnVerHechizos.Location = new System.Drawing.Point(949, 745);
            this.btnVerHechizos.Name = "btnVerHechizos";
            this.btnVerHechizos.Size = new System.Drawing.Size(193, 60);
            this.btnVerHechizos.TabIndex = 1;
            this.btnVerHechizos.Text = "Ver Hechizos";
            this.btnVerHechizos.UseVisualStyleBackColor = true;
            this.btnVerHechizos.Click += new System.EventHandler(this.btnVerHechizos_Click);
            // 
            // frmListadoMagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1205, 844);
            this.Controls.Add(this.btnVerHechizos);
            this.Controls.Add(this.dgvMagos);
            this.Name = "frmListadoMagos";
            this.Text = "Listado Magos";
            this.Load += new System.EventHandler(this.listadoMagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagos;
        private System.Windows.Forms.Button btnVerHechizos;
    }
}


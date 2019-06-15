namespace Presentacion
{
    partial class frmVerHechizos
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
            this.dgvHechizo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHechizo
            // 
            this.dgvHechizo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizo.Location = new System.Drawing.Point(14, 23);
            this.dgvHechizo.Name = "dgvHechizo";
            this.dgvHechizo.RowTemplate.Height = 33;
            this.dgvHechizo.Size = new System.Drawing.Size(705, 734);
            this.dgvHechizo.TabIndex = 0;
            // 
            // frmVerHechizos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 780);
            this.Controls.Add(this.dgvHechizo);
            this.Name = "frmVerHechizos";
            this.Text = "Hechizos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHechizo;
    }
}
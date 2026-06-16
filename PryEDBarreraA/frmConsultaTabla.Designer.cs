namespace PryEDBarreraA
{
    partial class frmConsultaTabla
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.dgvConsultarTabla = new System.Windows.Forms.DataGridView();
            this.lblTabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(12, 15);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(37, 13);
            this.lblTabla.TabIndex = 0;
            this.lblTabla.Text = "Tabla:";
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Location = new System.Drawing.Point(55, 12);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(200, 21);
            this.cmbConsultar.TabIndex = 1;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(271, 11);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(75, 23);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Consultar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // dgvConsultarTabla
            // 
            this.dgvConsultarTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarTabla.Location = new System.Drawing.Point(12, 45);
            this.dgvConsultarTabla.Name = "dgvConsultarTabla";
            this.dgvConsultarTabla.Size = new System.Drawing.Size(660, 355);
            this.dgvConsultarTabla.TabIndex = 3;
            // 
            // frmConsultaTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dgvConsultarTabla);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.lblTabla);
            this.Name = "frmConsultaTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de tabla";
            this.Load += new System.EventHandler(this.frmConsultaTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cmbConsultar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.DataGridView dgvConsultarTabla;
    }
}
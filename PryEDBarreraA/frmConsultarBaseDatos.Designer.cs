namespace PryEDBarreraA
{
    partial class frmConsultarSQL
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
            this.lblSQL = new System.Windows.Forms.Label();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvConsultarBaseDeDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarBaseDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(12, 15);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(30, 13);
            this.lblSQL.TabIndex = 0;
            this.lblSQL.Text = "SQL:";
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(48, 12);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(460, 20);
            this.txtSQL.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(524, 11);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(605, 11);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvConsultarBaseDeDatos
            // 
            this.dgvConsultarBaseDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarBaseDeDatos.Location = new System.Drawing.Point(12, 45);
            this.dgvConsultarBaseDeDatos.Name = "dgvConsultarBaseDeDatos";
            this.dgvConsultarBaseDeDatos.Size = new System.Drawing.Size(668, 355);
            this.dgvConsultarBaseDeDatos.TabIndex = 4;
            // 
            // frmConsultarSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 411);
            this.Controls.Add(this.dgvConsultarBaseDeDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.lblSQL);
            this.Name = "frmConsultarSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarBaseDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvConsultarBaseDeDatos;
    }
}
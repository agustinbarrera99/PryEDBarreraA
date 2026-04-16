namespace PryEDBarreraA
{
    partial class frmColores
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
            this.lblColores = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(28, 46);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(47, 13);
            this.lblColores.TabIndex = 0;
            this.lblColores.Text = "Nombre:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(81, 43);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(224, 20);
            this.txtColor.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(31, 87);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(181, 87);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(124, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(31, 129);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(274, 212);
            this.lstColores.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 363);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColores);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstColores;
    }
}
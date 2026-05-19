namespace PryEDBarreraA
{
    partial class frmArbol
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.gbNuevo.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(13, 13);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(195, 145);
            this.tvArbol.TabIndex = 0;
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.textBox3);
            this.gbNuevo.Controls.Add(this.textBox2);
            this.gbNuevo.Controls.Add(this.textBox1);
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Location = new System.Drawing.Point(226, 13);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(205, 145);
            this.gbNuevo.TabIndex = 1;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cmbCodigo);
            this.gbEliminar.Controls.Add(this.label1);
            this.gbEliminar.Location = new System.Drawing.Point(437, 13);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(187, 75);
            this.gbEliminar.TabIndex = 2;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Elemento a eliminar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(7, 84);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(52, 28);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(105, 21);
            this.cmbCodigo.TabIndex = 2;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(538, 97);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(86, 25);
            this.btnEquilibrar.TabIndex = 3;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // gbListado
            // 
            this.gbListado.Location = new System.Drawing.Point(13, 176);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(612, 186);
            this.gbListado.TabIndex = 4;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado del arbol";
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.tvArbol);
            this.Name = "frmArbol";
            this.Text = "frmArbol";
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox gbListado;
    }
}
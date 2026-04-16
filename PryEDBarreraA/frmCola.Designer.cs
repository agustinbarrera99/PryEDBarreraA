namespace PryEDBarreraA
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.pbCola = new System.Windows.Forms.PictureBox();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteEliminado = new System.Windows.Forms.TextBox();
            this.txtNombreEliminado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoEliminado = new System.Windows.Forms.TextBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).BeginInit();
            this.gbNuevo.SuspendLayout();
            this.gbEliminado.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCola
            // 
            this.pbCola.Image = ((System.Drawing.Image)(resources.GetObject("pbCola.Image")));
            this.pbCola.Location = new System.Drawing.Point(12, 12);
            this.pbCola.Name = "pbCola";
            this.pbCola.Size = new System.Drawing.Size(223, 223);
            this.pbCola.TabIndex = 0;
            this.pbCola.TabStop = false;
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Location = new System.Drawing.Point(253, 12);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(235, 161);
            this.gbNuevo.TabIndex = 1;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo elemento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(19, 96);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Trámite:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(116, 96);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(76, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.btnEliminar);
            this.gbEliminado.Controls.Add(this.txtTramiteEliminado);
            this.gbEliminado.Controls.Add(this.txtNombreEliminado);
            this.gbEliminado.Controls.Add(this.label1);
            this.gbEliminado.Controls.Add(this.label2);
            this.gbEliminado.Controls.Add(this.label3);
            this.gbEliminado.Controls.Add(this.txtCodigoEliminado);
            this.gbEliminado.Location = new System.Drawing.Point(511, 13);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Size = new System.Drawing.Size(242, 160);
            this.gbEliminado.TabIndex = 2;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = "Elemento eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(90, 127);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtTramiteEliminado
            // 
            this.txtTramiteEliminado.Location = new System.Drawing.Point(126, 91);
            this.txtTramiteEliminado.Name = "txtTramiteEliminado";
            this.txtTramiteEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteEliminado.TabIndex = 12;
            // 
            // txtNombreEliminado
            // 
            this.txtNombreEliminado.Location = new System.Drawing.Point(126, 64);
            this.txtNombreEliminado.Name = "txtNombreEliminado";
            this.txtNombreEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEliminado.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo:";
            // 
            // txtCodigoEliminado
            // 
            this.txtCodigoEliminado.Location = new System.Drawing.Point(126, 30);
            this.txtCodigoEliminado.Name = "txtCodigoEliminado";
            this.txtCodigoEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEliminado.TabIndex = 7;
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dgvCola);
            this.gbListado.Controls.Add(this.lstCola);
            this.gbListado.Location = new System.Drawing.Point(13, 242);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(740, 196);
            this.gbListado.TabIndex = 3;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(7, 20);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(180, 160);
            this.lstCola.TabIndex = 0;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvCola.Location = new System.Drawing.Point(240, 20);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(484, 160);
            this.dgvCola.TabIndex = 1;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Tramite";
            this.clmTramite.Name = "clmTramite";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.pbCola);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).EndInit();
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.gbEliminado.ResumeLayout(false);
            this.gbEliminado.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCola;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteEliminado;
        private System.Windows.Forms.TextBox txtNombreEliminado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoEliminado;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
    }
}
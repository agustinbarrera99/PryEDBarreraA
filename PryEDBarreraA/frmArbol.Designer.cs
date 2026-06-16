namespace PryEDBarreraA
{
    partial class frmArbol
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.gbNuevo.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(13, 13);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(677, 283);
            this.tvArbol.TabIndex = 0;
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Location = new System.Drawing.Point(485, 302);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(205, 145);
            this.gbNuevo.TabIndex = 1;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
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
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(53, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(53, 81);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.label1);
            this.gbEliminar.Controls.Add(this.cmbCodigo);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Location = new System.Drawing.Point(485, 453);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(205, 90);
            this.gbEliminar.TabIndex = 2;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Elemento a eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(52, 28);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(105, 21);
            this.cmbCodigo.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(62, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(495, 549);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(86, 25);
            this.btnEquilibrar.TabIndex = 3;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.optInOrden);
            this.gbListado.Controls.Add(this.optPreOrden);
            this.gbListado.Controls.Add(this.optPostOrden);
            this.gbListado.Controls.Add(this.dgvArbol);
            this.gbListado.Location = new System.Drawing.Point(12, 302);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(467, 272);
            this.gbListado.TabIndex = 4;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado del arbol";
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Checked = true;
            this.optInOrden.Location = new System.Drawing.Point(6, 19);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(66, 17);
            this.optInOrden.TabIndex = 1;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(6, 42);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 2;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optOrden_CheckedChanged);
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(6, 65);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 3;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optOrden_CheckedChanged);
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCodigo,
                this.colNombre,
                this.colTramite });
            this.dgvArbol.Location = new System.Drawing.Point(113, 19);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.Size = new System.Drawing.Size(345, 247);
            this.dgvArbol.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 130;
            // 
            // colTramite
            // 
            this.colTramite.HeaderText = "Tramite";
            this.colTramite.Name = "colTramite";
            this.colTramite.Width = 110;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 590);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.tvArbol);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol binario de busqueda";
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
    }
}
namespace PryEDBarreraA
{
    partial class Grafo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbOrigenCarga = new System.Windows.Forms.ComboBox();
            this.cmbDestinoCarga = new System.Windows.Forms.ComboBox();
            this.txtPrecioCarga = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrarConsulta = new System.Windows.Forms.Button();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.txtPrecioCarga);
            this.groupBox1.Controls.Add(this.cmbDestinoCarga);
            this.groupBox1.Controls.Add(this.cmbOrigenCarga);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(263, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(13, 67);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(14, 103);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(57, 19);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenCarga.TabIndex = 3;
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(57, 64);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinoCarga.TabIndex = 4;
            this.cmbDestinoCarga.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtPrecioCarga
            // 
            this.txtPrecioCarga.Location = new System.Drawing.Point(57, 100);
            this.txtPrecioCarga.Name = "txtPrecioCarga";
            this.txtPrecioCarga.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioCarga.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(103, 140);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(16, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.btnConsultar);
            this.gbConsulta.Controls.Add(this.btnBorrarConsulta);
            this.gbConsulta.Controls.Add(this.txtPrecioConsulta);
            this.gbConsulta.Controls.Add(this.cmbDestinoConsulta);
            this.gbConsulta.Controls.Add(this.cmbOrigenConsulta);
            this.gbConsulta.Controls.Add(this.label2);
            this.gbConsulta.Controls.Add(this.label3);
            this.gbConsulta.Controls.Add(this.label4);
            this.gbConsulta.Location = new System.Drawing.Point(477, 13);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(200, 183);
            this.gbConsulta.TabIndex = 2;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de datos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(21, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarConsulta
            // 
            this.btnBorrarConsulta.Location = new System.Drawing.Point(108, 140);
            this.btnBorrarConsulta.Name = "btnBorrarConsulta";
            this.btnBorrarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarConsulta.TabIndex = 14;
            this.btnBorrarConsulta.Text = "Borrar";
            this.btnBorrarConsulta.UseVisualStyleBackColor = true;
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(62, 100);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.ReadOnly = true;
            this.txtPrecioConsulta.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioConsulta.TabIndex = 13;
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(62, 61);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinoConsulta.TabIndex = 12;
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(62, 19);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenConsulta.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen";
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dgvViajes);
            this.gbListar.Controls.Add(this.btnVerTodos);
            this.gbListar.Controls.Add(this.btnListarOrigenes);
            this.gbListar.Controls.Add(this.cmbHasta);
            this.gbListar.Controls.Add(this.lblHasta);
            this.gbListar.Controls.Add(this.btnListarDestinos);
            this.gbListar.Controls.Add(this.cmbDesde);
            this.gbListar.Controls.Add(this.lblDesde);
            this.gbListar.Location = new System.Drawing.Point(13, 203);
            this.gbListar.Name = "gbListar";
            this.gbListar.Size = new System.Drawing.Size(664, 235);
            this.gbListar.TabIndex = 3;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listar viajes";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(7, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(54, 17);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 1;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(181, 15);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(91, 23);
            this.btnListarDestinos.TabIndex = 2;
            this.btnListarDestinos.Text = "Listar destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(453, 15);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(91, 23);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(326, 17);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(282, 20);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(550, 15);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(108, 23);
            this.btnVerTodos.TabIndex = 6;
            this.btnVerTodos.Text = "Ver todos los viajes";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(10, 47);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(648, 182);
            this.dgvViajes.TabIndex = 7;
            // 
            // Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Grafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrafo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbListar.ResumeLayout(false);
            this.gbListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioCarga;
        private System.Windows.Forms.ComboBox cmbDestinoCarga;
        private System.Windows.Forms.ComboBox cmbOrigenCarga;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrarConsulta;
        private System.Windows.Forms.TextBox txtPrecioConsulta;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Button btnVerTodos;
    }
}
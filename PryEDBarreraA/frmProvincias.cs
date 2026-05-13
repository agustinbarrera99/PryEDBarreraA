using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmProvincias : Form
    {
        clsArchivoTexto archivo = new clsArchivoTexto();

        public frmProvincias()
        {
            InitializeComponent();
            archivo.NombreArchivo = "Provincias.csv";
            archivo.Recorrer(lstProvincias);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            archivo.Grabar(txtCodigo.Text, txtNombre.Text);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCodigo.Focus();
            archivo.Recorrer(lstProvincias);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            archivo.Recorrer(lstProvincias);
        }
    }
}
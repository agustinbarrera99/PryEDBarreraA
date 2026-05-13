using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmCiudades : Form
    {
        clsArchivoTexto archivo = new clsArchivoTexto();

        public frmCiudades()
        {
            InitializeComponent();
            archivo.NombreArchivo = "Ciudades.csv";
            archivo.Recorrer(lstCiudades);
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
            archivo.Recorrer(lstCiudades);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            archivo.Recorrer(lstCiudades);
        }
    }
}
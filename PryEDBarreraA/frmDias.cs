using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmDias : Form
    {
        clsArchivoTexto archivo = new clsArchivoTexto();

        public frmDias()
        {
            InitializeComponent();
            archivo.NombreArchivo = "Dias.txt";
            archivo.Recorrer(lstDias);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un día antes de grabar.");
                return;
            }
            archivo.Grabar(txtNombre.Text);
            txtNombre.Clear();
            txtNombre.Focus();
            archivo.Recorrer(lstDias);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            archivo.Recorrer(lstDias);
        }
    }
}
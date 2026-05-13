using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmColores : Form
    {
        clsArchivoTexto archivo = new clsArchivoTexto();

        public frmColores()
        {
            InitializeComponent();
            archivo.NombreArchivo = "Colores.txt";
            archivo.Recorrer(lstColores);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Ingrese un color antes de grabar.");
                return;
            }

            archivo.Grabar(txtColor.Text);
            archivo.Recorrer(lstColores);
            txtColor.Text = "";
            txtColor.Focus();
        }
    }
}
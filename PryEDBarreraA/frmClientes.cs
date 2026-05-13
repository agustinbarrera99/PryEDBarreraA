using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmClientes : Form
    {
        clsArchivoTexto archivo = new clsArchivoTexto();

        public frmClientes()
        {
            InitializeComponent();
            archivo.NombreArchivo = "Clientes.csv";
            archivo.Recorrer(dgvClientes);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDeuda.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            archivo.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            archivo.Recorrer(dgvClientes);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtCodigo.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            archivo.Recorrer(dgvClientes);
        }
    }
}
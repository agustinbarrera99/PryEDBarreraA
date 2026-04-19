using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Clientes.csv";
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDeuda.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            x.Recorrer(dgvClientes);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombreArchivo = "Clientes.csv";
            x.Recorrer(dgvClientes);
        }
    }
}

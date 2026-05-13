using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmAlumnos : Form
    {
        clsArchivoTexto archivo = new clsArchivoTexto();

        public frmAlumnos()
        {
            InitializeComponent();
            archivo.NombreArchivo = "Alumnos.csv";
            archivo.Recorrer(dgvAlumnos);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtCarrera.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            archivo.Grabar(txtCodigo.Text, txtNombre.Text, txtCarrera.Text);
            archivo.Recorrer(dgvAlumnos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCarrera.Text = "";
            txtCodigo.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            archivo.Recorrer(dgvAlumnos);
        }
    }
}
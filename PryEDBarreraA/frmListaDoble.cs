using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmListaDoble : Form
    {
        clsListaDoble Lista = new clsListaDoble();

        public frmListaDoble()
        {
            InitializeComponent();

            // Conectar eventos que faltan en el designer
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            optAscendente.CheckedChanged += new EventHandler(rbOrden_CheckedChanged);
            rbDescendente.CheckedChanged += new EventHandler(rbOrden_CheckedChanged);

            // Selección por defecto
            optAscendente.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            int codigo;
            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe ser un número entero.");
                return;
            }

            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = codigo;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            Lista.Agregar(nuevo);
            RefrescarVistas();

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbListaDoble.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento de la lista para eliminar.");
                return;
            }

            string seleccionado = cmbListaDoble.SelectedItem.ToString();
            string codigoStr = seleccionado.Split('-')[0].Trim();

            int codigoAEliminar;
            if (!int.TryParse(codigoStr, out codigoAEliminar))
            {
                MessageBox.Show("No se pudo obtener el código del elemento seleccionado.");
                return;
            }

            Lista.Eliminar(codigoAEliminar);
            RefrescarVistas();
        }

        private void rbOrden_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarVistas();
        }

        private void RefrescarVistas()
        {
            if (optAscendente.Checked)
            {
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(cmbListaDoble);
            }
            else
            {
                Lista.Recorrer_desc(lstListaDoble);
                Lista.Recorrer_desc(dgvListaDoble);
                Lista.Recorrer_desc(cmbListaDoble);
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmListaSimple : Form
    {
        clsListSimple listaSimple = new clsListSimple();

        public frmListaSimple()
        {
            InitializeComponent();
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

            clsNodo nodo = new clsNodo();
            nodo.Codigo = codigo;
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            listaSimple.Agregar(nodo);
            RefrescarVistas();

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbListaSimple.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento de la lista para eliminar.");
                return;
            }

            // El combo muestra "codigo - nombre - tramite", extraemos solo el codigo
            string seleccionado = cmbListaSimple.SelectedItem.ToString();
            string codigoStr = seleccionado.Split('-')[0].Trim();

            int codigoAEliminar;
            if (!int.TryParse(codigoStr, out codigoAEliminar))
            {
                MessageBox.Show("No se pudo obtener el código del elemento seleccionado.");
                return;
            }

            listaSimple.Eliminar(codigoAEliminar);
            RefrescarVistas();
        }

        private void RefrescarVistas()
        {
            listaSimple.Recorrer(lstListaSimple);
            listaSimple.Recorrer(dgvListaSimple);
            listaSimple.Recorrer(cmbListaSimple);
        }
    }
}
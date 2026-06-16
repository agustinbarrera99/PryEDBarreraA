using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmArbol : Form
    {
        private clsArbolBinario Arbol = new clsArbolBinario();

        public frmArbol()
        {
            InitializeComponent();
            optInOrden.Checked = true;
        }

        private void ActualizarCombo()
        {
            cmbCodigo.Items.Clear();
            PoblarComboInOrden(Arbol.Raiz);
        }

        private void PoblarComboInOrden(clsNodo actual)
        {
            if (actual == null) return;
            PoblarComboInOrden(actual.Anterior);
            cmbCodigo.Items.Add(actual.Codigo + " - " + actual.Nombre + " - " + actual.Tramite);
            PoblarComboInOrden(actual.Siguiente);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Completá todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser un número entero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsNodo nodo = new clsNodo();
            nodo.Codigo = codigo;
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            Arbol.Agregar(nodo);
            Arbol.Recorrer(tvArbol);
            ActualizarListado();
            ActualizarCombo();

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un código a eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // El combo muestra "codigo - nombre - tramite"
            string seleccion = cmbCodigo.SelectedItem.ToString();
            int codigo = int.Parse(seleccion.Split('-')[0].Trim());

            bool eliminado = Arbol.Eliminar(codigo);
            if (eliminado)
            {
                MessageBox.Show("Elemento eliminado.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Arbol.Recorrer(tvArbol);
                ActualizarListado();
                ActualizarCombo();
            }
            else
            {
                MessageBox.Show("No se encontró el elemento.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(tvArbol);
            ActualizarListado();
            MessageBox.Show("Árbol equilibrado.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void optOrden_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private void ActualizarListado()
        {
            string orden = "InOrden";
            if (optPreOrden.Checked) orden = "PreOrden";
            if (optPostOrden.Checked) orden = "PostOrden";
            Arbol.Recorrer(dgvArbol, orden);
        }
    }
}
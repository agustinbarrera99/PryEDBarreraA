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
    public partial class frmPila : Form
    {
        clsPila pila = new clsPila();
        public frmPila()
        {

            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            pila.Agregar(nodo);
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            if (pila.Primero != null)
            {
                lblCodigo1.Text = Convert.ToString(pila.Primero.Codigo);
                lblNombre1.Text = pila.Primero.Nombre;
                lblTramite1.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
            } else
            {
                MessageBox.Show("La pila esta vacia");
            }

        }
    }
}

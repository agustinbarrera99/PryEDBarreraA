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
    public partial class frmCola : Form
    {

        clsCola cola = new clsCola();
        public frmCola()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            cola.Agregar(nodo);
            cola.Recorrer(dgvCola);
            cola.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            lblCodigo1.Text = Convert.ToString(cola.Primero.Codigo);
            lblNombre1.Text = cola.Primero.Nombre;
            lblTramite1.Text = cola.Primero.Tramite;
            cola.Eliminar();
            cola.Recorrer(dgvCola);
            cola.Recorrer(lstCola);
        }
    }
}

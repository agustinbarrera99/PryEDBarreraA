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
    public partial class frmListaSimple : Form
    {
        clsListSimple listaSimple = new clsListSimple();
        public frmListaSimple()
        
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;
            listaSimple.Agregar(nodo);
            listaSimple.Recorrer(lstListaSimple);
            listaSimple.Recorrer(dgvListaSimple);
            listaSimple.Recorrer(cmbListaSimple);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            listaSimple.Eliminar(nodo.Codigo);
            listaSimple.Recorrer(lstListaSimple);
            listaSimple.Recorrer(dgvListaSimple);
            listaSimple.Recorrer(cmbListaSimple);
        }
    }
}

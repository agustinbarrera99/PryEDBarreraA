using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmGrafo : Form
    {
        private clsGrafo grafo = new clsGrafo();

        public frmGrafo()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            grafo.MostrarCiudades(cmbOrigenCarga);
            grafo.MostrarCiudades(cmbDestinoCarga);
            grafo.MostrarCiudades(cmbOrigenConsulta);
            grafo.MostrarCiudades(cmbDestinoConsulta);
            grafo.MostrarCiudades(cmbDesde);
            grafo.MostrarCiudades(cmbHasta);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cmbOrigenCarga.SelectedIndex == cmbDestinoCarga.SelectedIndex)
            {
                MessageBox.Show("El origen y el destino no pueden ser iguales.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCarga.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresá un precio válido mayor a cero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int origen = cmbOrigenCarga.SelectedIndex;
            int destino = cmbDestinoCarga.SelectedIndex;

            grafo.Agregar(destino, origen, (int)precio);
            txtPrecioCarga.Clear();
            MessageBox.Show("Viaje cargado correctamente.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("¿Borrar todos los viajes?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                grafo.BorrarTodo();
                dgvViajes.Rows.Clear();
                dgvViajes.Columns.Clear();
                MessageBox.Show("Datos borrados.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int origen = cmbOrigenConsulta.SelectedIndex;
            int destino = cmbDestinoConsulta.SelectedIndex;

            decimal precio = grafo.Consultar(destino, origen);

            if (precio == 0)
                txtPrecioConsulta.Text = "Sin viaje";
            else
                txtPrecioConsulta.Text = precio.ToString("F2");
        }

        private void btnBorrarConsulta_Click(object sender, EventArgs e)
        {
            txtPrecioConsulta.Clear();
            cmbOrigenConsulta.SelectedIndex = 0;
            cmbDestinoConsulta.SelectedIndex = 0;
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            int origen = grafo.ObtenerIndice(cmbDesde.SelectedItem.ToString());
            grafo.MostrarDestinos(origen, dgvViajes);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            int destino = grafo.ObtenerIndice(cmbHasta.SelectedItem.ToString());
            grafo.MostrarOrigenes(destino, dgvViajes);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvViajes);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
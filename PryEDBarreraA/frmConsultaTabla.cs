using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmConsultaTabla : Form
    {
        private clsBaseDeDatos bd = new clsBaseDeDatos();

        public frmConsultaTabla()
        {
            InitializeComponent();
        }

        private void frmConsultaTabla_Load(object sender, EventArgs e)
        {
            string[] tablas = bd.ObtenerTablas();
            cmbConsultar.Items.Clear();
            foreach (string tabla in tablas)
                cmbConsultar.Items.Add(tabla);

            if (cmbConsultar.Items.Count > 0)
                cmbConsultar.SelectedIndex = 0;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (cmbConsultar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una tabla primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bd.Listar(cmbConsultar.Text, dgvConsultarTabla);
        }
    }
}
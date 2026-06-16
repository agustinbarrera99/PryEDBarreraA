using System;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    public partial class frmConsultarSQL : Form
    {
        private clsBaseDeDatos db = new clsBaseDeDatos();

        public frmConsultarSQL()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string sql = txtSQL.Text.Trim();
            if (string.IsNullOrEmpty(sql))
            {
                MessageBox.Show("Ingresá una consulta SQL.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            db.Listar(dgvConsultarBaseDeDatos, sql);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSQL.Clear();
            dgvConsultarBaseDeDatos.DataSource = null;
            dgvConsultarBaseDeDatos.Rows.Clear();
            dgvConsultarBaseDeDatos.Columns.Clear();
        }
    }
}
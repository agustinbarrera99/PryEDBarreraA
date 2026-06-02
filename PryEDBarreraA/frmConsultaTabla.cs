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
    public partial class frmConsultaTabla : Form
    {
        public frmConsultaTabla()
        {
            InitializeComponent();
        }

        // ─────────────────────────────────────────────────────────────
        // Al cargar el formulario, se pobla el ComboBox con los
        // nombres de las tablas que existen en la base de datos
        // ─────────────────────────────────────────────────────────────
        private void frmConsultaTabla_Load(object sender, EventArgs e)
        {
            clsBaseDeDatos bd = new clsBaseDeDatos();
            List<string> tablas = bd.ObtenerTablas();

            cmbConsultar.Items.Clear();

            foreach (string tabla in tablas)
            {
                cmbConsultar.Items.Add(tabla);
            }

            // Seleccionar el primer ítem por defecto (si hay tablas)
            if (cmbConsultar.Items.Count > 0)
                cmbConsultar.SelectedIndex = 0;
        }

        // ─────────────────────────────────────────────────────────────
        // FIX: el orden era (texto, grilla) — debe ser (grilla, texto)
        // ─────────────────────────────────────────────────────────────


        private void btnLlamar_Click_1(object sender, EventArgs e)
        {
            if (cmbConsultar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una tabla primero.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            clsBaseDeDatos bd = new clsBaseDeDatos();
            bd.Listar(dgvConsultarTabla, cmbConsultar.Text); // ← orden correcto
        }
    }
}

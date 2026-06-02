using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string cadenaConexion;
        public clsBaseDeDatos()
        {
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaRaiz = System.IO.Path.GetFullPath(System.IO.Path.Combine(rutaBase, @"..\..\..\"));
            string rutaBD = System.IO.Path.Combine(rutaRaiz, "data", "Libreria.accdb");
            cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaBD};";
        }

        public List<string> ObtenerTablas()
        {
            List<string> tablas = new List<string>();

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                // GetSchema("Tables") devuelve metadatos de todas las tablas
                DataTable esquema = conexion.GetSchema("Tables");

                foreach (DataRow fila in esquema.Rows)
                {
                    string tipo = fila["TABLE_TYPE"].ToString();
                    string nombre = fila["TABLE_NAME"].ToString();

                    // Solo tablas reales del usuario (TABLE o VIEW),
                    // descartando las tablas internas "MSys..."
                    if ((tipo == "TABLE" || tipo == "VIEW")
                        && !nombre.StartsWith("MSys"))
                    {
                        tablas.Add(nombre);
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tablas: " + ex.Message);
            }

            return tablas;
        }

        // ─────────────────────────────────────────────────────────────
        // Lista el contenido completo de una tabla en el DataGridView
        // ─────────────────────────────────────────────────────────────
        public void Listar(DataGridView Grilla, string tabla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }
    }
}
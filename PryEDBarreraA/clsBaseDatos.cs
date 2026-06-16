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
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;

        private string cadenaConexion;

        public clsBaseDeDatos()
        {
            string rutaDB = AppDomain.CurrentDomain.BaseDirectory + "data\\Libreria.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaDB;
            conexion = new OleDbConnection(cadenaConexion);
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter();
        }

        private void Abrir()
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
        }

        private void Cerrar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public string[] ObtenerTablas()
        {
            string[] resultado = new string[0];
            try
            {
                Abrir();
                DataTable esquema = conexion.GetSchema("Tables");

                int count = 0;
                foreach (DataRow fila in esquema.Rows)
                {
                    string tipo = fila["TABLE_TYPE"].ToString();
                    string nombre = fila["TABLE_NAME"].ToString();
                    if ((tipo == "TABLE" || tipo == "VIEW") && !nombre.StartsWith("MSys"))
                        count++;
                }

                resultado = new string[count];
                int i = 0;
                foreach (DataRow fila in esquema.Rows)
                {
                    string tipo = fila["TABLE_TYPE"].ToString();
                    string nombre = fila["TABLE_NAME"].ToString();
                    if ((tipo == "TABLE" || tipo == "VIEW") && !nombre.StartsWith("MSys"))
                        resultado[i++] = nombre;
                }

                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tablas: " + ex.Message);
            }
            return resultado;
        }

        public void Listar(string tabla, DataGridView Grilla)
        {
            try
            {
                Abrir();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        public void Listar(DataGridView Grilla, string sql)
        {
            try
            {
                Abrir();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        public void EjecutarSQL(string sql)
        {
            try
            {
                Abrir();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " + ex.Message);
            }
        }

        public void Insertar(string tabla, string columnas, string valores)
        {
            EjecutarSQL("INSERT INTO " + tabla + " (" + columnas + ") VALUES (" + valores + ")");
        }

        public void Actualizar(string tabla, string set, string condicion)
        {
            EjecutarSQL("UPDATE " + tabla + " SET " + set + " WHERE " + condicion);
        }

        public void Eliminar(string tabla, string condicion)
        {
            EjecutarSQL("DELETE FROM " + tabla + " WHERE " + condicion);
        }
    }
}
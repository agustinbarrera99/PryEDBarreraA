using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsGrafo
    {
        private string[] ciudades = new string[] { "Cordoba", "Santa Fe", "Rosario", "Mendoza", "San Luis" };
        private decimal[,] precio = new decimal[5, 5];

        public void Agregar(int f, int c, decimal p)
        {
            precio[f, c] = p;
        }

        public void Eliminar(int f, int c)
        {
            precio[f, c] = 0;
        }

        public decimal Consultar(int f, int c)
        {
            return precio[f, c];

        }

        public void BorrarTodo()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    precio[f, c] = 0;
                }
            }
        }

        public void MostrarDestinos(int f, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("Destino", "Destino");
            dgv.Columns.Add("Precio", "Precio");
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;
            dgv.Rows.Clear();
            for (int c = 0; c < 5; c++)
            {
                dgv.Rows.Add(ciudades[c], precio[f, c]);
            }
        }
    }
}

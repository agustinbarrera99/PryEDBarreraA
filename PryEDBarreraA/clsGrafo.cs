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
        private String[] Ciudades = new String[] { "Córdoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };
        private Decimal[,] Precio = new Decimal[5, 5];
        private Int32 Cantidad
        {
            get { return Ciudades.Length; }
        }

        public void Agregar(Int32 c, Int32 f, Int32 p)
        {
            Precio[c, f] = p;
        }

        public void Eliminar(Int32 c, Int32 f)
        {
            Precio[c, f] = 0;
        }

        public Decimal Consultar(Int32 c, Int32 f)
        {
            return Precio[c, f];
        }

        public void BorrarTodo()
        {
            for (Int32 f = 0; f < Cantidad; f++)
            {
                for (Int32 c = 0; c < Cantidad; c++)
                {
                    Precio[c, f] = 0;
                }
            }
        }

        public void MostrarDestinos(Int32 origen, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            for (Int32 c = 0; c < Cantidad; c++)
            {
                if (Precio[c, origen] > 0)
                    Grilla.Rows.Add(Ciudades[c], Precio[c, origen]);
            }
        }

        public void MostrarOrigenes(Int32 destino, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            for (Int32 f = 0; f < Cantidad; f++)
            {
                if (Precio[destino, f] > 0)
                    Grilla.Rows.Add(Ciudades[f], Precio[destino, f]);
            }
        }

        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("NomOrigen", "Origen");
            for (Int32 i = 0; i < Cantidad; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (Int32 f = 0; f < Cantidad; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
                for (Int32 c = 0; c < Cantidad; c++)
                {
                    Grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }

        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (Int32 i = 0; i < Cantidad; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            cmb.SelectedIndex = 0;
        }

        public Int32 ObtenerIndice(String ciudad)
        {
            for (Int32 i = 0; i < Cantidad; i++)
            {
                if (Ciudades[i] == ciudad)
                    return i;
            }
            return -1;
        }
    }
}
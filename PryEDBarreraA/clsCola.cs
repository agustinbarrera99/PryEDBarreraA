using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDBarreraA
{
    internal class clsCola
    {
        public string NombreArchivo;
        private clsNodo pri;
        private clsNodo ult;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView dgv)
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox lst)
        {
            clsNodo aux = Primero;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Primero;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer() {
            StreamWriter AD = new StreamWriter(NombreArchivo , true);
            clsNodo aux = Primero;
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
